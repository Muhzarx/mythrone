using UnityEngine;
using UnityEngine.AI;
using Mythrone.Heroes;
namespace Mythrone.Input {
 [RequireComponent(typeof(HeroAgent))]
 public class TopDownPlayerController : MonoBehaviour {
  public float moveSpeed=6f; NavMeshAgent agent; HeroAgent hero; Camera cam; HeroAgent target;
  void Awake(){agent=GetComponent<NavMeshAgent>();hero=GetComponent<HeroAgent>();cam=Camera.main;if(agent)agent.speed=moveSpeed;}
  void Update(){
   if(UnityEngine.Input.GetMouseButtonDown(1)&&cam){Ray r=cam.ScreenPointToRay(UnityEngine.Input.mousePosition);if(Physics.Raycast(r,out var hit,500)) {if(agent&&agent.isOnNavMesh)agent.SetDestination(hit.point);}}
   if(UnityEngine.Input.GetMouseButtonDown(0))SelectTarget();
   if(UnityEngine.Input.GetKeyDown(KeyCode.Space)&&target)hero.BasicAttack(target);
  }
  void SelectTarget(){if(!cam)return;Ray r=cam.ScreenPointToRay(UnityEngine.Input.mousePosition);if(Physics.Raycast(r,out var h,500)){target=h.collider.GetComponentInParent<HeroAgent>();if(target&&!hero.IsEnemy(target))target=null;}}
 }
}