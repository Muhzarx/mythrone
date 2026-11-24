using UnityEngine;
using UnityEngine.AI;
using Mythrone.Heroes; using Mythrone.Core;
namespace Mythrone.AI {
 public enum BotDifficulty { Easy, Normal, Hard }
 public class BotBrain : MonoBehaviour {
  public BotDifficulty difficulty=BotDifficulty.Normal; public Transform[] laneWaypoints;
  public float acquireRange=10, retreatHealthFraction=.25f; NavMeshAgent nav; HeroAgent self,target; int waypoint;
  float thinkAt;
  void Awake(){nav=GetComponent<NavMeshAgent>();self=GetComponent<HeroAgent>();}
  void Update(){if(!self||self.Health.IsDead||Time.time<thinkAt)return;thinkAt=Time.time+(difficulty==BotDifficulty.Easy?.8f:difficulty==BotDifficulty.Normal?.45f:.22f);Think();}
  void Think(){
   if(self.Health.Current/self.Health.Max<retreatHealthFraction){if(laneWaypoints.Length>0)MoveTo(laneWaypoints[0].position);return;}
   target=FindEnemy();
   if(target){float d=Vector3.Distance(transform.position,target.transform.position);float range=self.definition?self.definition.attackRange:2f;if(d<=range)self.BasicAttack(target);else if(difficulty!=BotDifficulty.Easy)MoveTo(target.transform.position);return;}
   if(laneWaypoints.Length>0){if(Vector3.Distance(transform.position,laneWaypoints[waypoint].position)<2f)waypoint=(waypoint+1)%laneWaypoints.Length;MoveTo(laneWaypoints[waypoint].position);}
  }
  HeroAgent FindEnemy(){var all=FindObjectsByType<HeroAgent>(FindObjectsSortMode.None);HeroAgent best=null;float score=acquireRange;foreach(var h in all){if(!self.IsEnemy(h)||h.Health.IsDead)continue;float d=Vector3.Distance(transform.position,h.transform.position);if(d<score){score=d;best=h;}}return best;}
  void MoveTo(Vector3 p){if(nav&&nav.isOnNavMesh)nav.SetDestination(p);}
 }
}