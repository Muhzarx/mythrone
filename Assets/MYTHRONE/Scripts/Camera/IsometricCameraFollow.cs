using UnityEngine;
namespace Mythrone.CameraSystem {
 public class IsometricCameraFollow : MonoBehaviour {
  public Transform target; public Vector3 offset=new Vector3(0,16,-12); public float smooth=8;
  void LateUpdate(){if(!target)return;Vector3 p=target.position+offset;transform.position=Vector3.Lerp(transform.position,p,Time.deltaTime*smooth);transform.rotation=Quaternion.Euler(50,0,0);}
 }
}