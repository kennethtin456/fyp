using UnityEngine;
using UnityEngine.UI;

public class Lap : MonoBehaviour {
	public int player_passed = 0;
	public int AI_passed = 0;
	public int num_checkpoint;
	[SerializeField] public int num_lap;
	[SerializeField] TextMesh endMessage;
	int end_countdown = 0;
	float time;
	
	void Awake(){
		num_checkpoint = transform.childCount;
	}
	void FixedUpdate (){
		if(end_countdown == 1){
			time += Time.deltaTime;
			if(time >= 3){
				Application.LoadLevel("MainMenu");
			}
		}
	}
	public void UpdateCheckpoint(string car, int checkpoint_no){
		if(car == "CarCollider"){
			if((player_passed+1)%num_checkpoint == checkpoint_no)
				player_passed++;
			if(player_passed >= num_checkpoint*num_lap){
				EndGame(1);
			}
		}
		else if(car == "AICarCollider"){
			if((AI_passed+1)%num_checkpoint == checkpoint_no)
				AI_passed++;
			if(AI_passed >= num_checkpoint*num_lap){
				EndGame(0);
			}
		}
	}
	
	void EndGame(int win){
		Behaviour timer = (Behaviour)GameObject.Find("Timer").GetComponent("Timer");
		timer.enabled = false;
		Behaviour carControl = (Behaviour)GameObject.Find("Car").GetComponent("CarUserControl");
		carControl.enabled = false;
		Behaviour carAIControl = (Behaviour)GameObject.Find("AICar").GetComponent("CarAIControl");
		carAIControl.enabled = false;
		if(win == 1)
			endMessage.text = "You Win!!";
		else
			endMessage.text = "You Lose";
		end_countdown = 1;
	}
}