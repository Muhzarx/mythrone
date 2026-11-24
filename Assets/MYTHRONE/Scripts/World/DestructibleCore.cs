using UnityEngine; using Mythrone.Combat; using Mythrone.Core;
namespace Mythrone.World {
 public class DestructibleCore : MonoBehaviour {
  public TeamId owner; public Health health; void Awake(){if(!health)health=GetComponent<Health>();if(!health)health=gameObject.AddComponent<Health>();health.Configure(5000);health.Died+=OnDestroyed;}
  void OnDestroyed(Health h){var match=FindFirstObjectByType<MatchManager>();if(match)match.CoreDestroyed(owner);}
 }
}