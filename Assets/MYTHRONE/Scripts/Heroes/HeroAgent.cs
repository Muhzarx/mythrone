using UnityEngine;
using Mythrone.Core; using Mythrone.Combat;
namespace Mythrone.Heroes {
 [RequireComponent(typeof(Health))]
 public class HeroAgent : MonoBehaviour {
  public HeroDefinition definition; public TeamId team; public int level=1; public int gold; public int experience;
  public Health Health {get; private set;}
  float nextAttack;
  void Awake(){Health=GetComponent<Health>(); if(definition)Health.Configure(definition.maxHealth);}
  public bool IsEnemy(HeroAgent other)=>other && other.team!=team;
  public void BasicAttack(HeroAgent target){
   if(!target || !IsEnemy(target) || target.Health.IsDead || Time.time<nextAttack)return;
   float range=definition?definition.attackRange:2.2f;
   if(Vector3.Distance(transform.position,target.transform.position)>range)return;
   nextAttack=Time.time+(definition?definition.attackCooldown:1.1f);
   float dmg=(definition?definition.attackDamage:50)*(1f+0.04f*(level-1));
   target.Health.Damage(dmg);
  }
  public void AddReward(int xp,int coins){experience+=xp;gold+=coins;while(experience>=level*100){experience-=level*100;level++;}}
 }
}