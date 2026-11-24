using UnityEngine; using Mythrone.Core;
public class MatchManager : MonoBehaviour {
 public enum MatchState { Preparing, Running, AzureVictory, CrimsonVictory }
 public MatchState State {get;private set;}=MatchState.Preparing;
 public void BeginMatch(){if(State==MatchState.Preparing)State=MatchState.Running;}
 public void CoreDestroyed(TeamId owner){if(State!=MatchState.Running)return;State=owner==TeamId.Azure?MatchState.CrimsonVictory:MatchState.AzureVictory;Debug.Log("MYTHRONE match ended: "+State);}
}