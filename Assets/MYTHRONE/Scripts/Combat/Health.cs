using System;
using UnityEngine;
namespace Mythrone.Combat {
 public class Health : MonoBehaviour {
  [SerializeField] float maxHealth=650; public float Current {get; private set;} public float Max=>maxHealth;
  public bool IsDead=>Current<=0; public event Action<Health> Died; public event Action<float,float> Changed;
  void Awake(){Current=maxHealth;}
  public void Configure(float value){maxHealth=Mathf.Max(1,value); Current=maxHealth; Changed?.Invoke(Current,maxHealth);}
  public void Damage(float amount){if(IsDead)return; Current=Mathf.Max(0,Current-Mathf.Max(0,amount)); Changed?.Invoke(Current,maxHealth); if(IsDead)Died?.Invoke(this);}
  public void Heal(float amount){if(IsDead)return; Current=Mathf.Min(maxHealth,Current+Mathf.Max(0,amount)); Changed?.Invoke(Current,maxHealth);}
 }
}