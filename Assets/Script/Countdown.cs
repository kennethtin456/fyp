using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(TextMesh))]
public class Countdown : MonoBehaviour {
	float time;
	Behaviour ai_script;
	Behaviour user_script;
	void Awake(){
		ai_script = (Behaviour)GameObject.Find("AICar").GetComponent("CarAIControl");
		if(GameObject.Find("Car") != null)
			user_script = (Behaviour)GameObject.Find("Car").GetComponent("CarUserControl");
		
		ai_script.enabled = false;
		if(user_script != null)
			user_script.enabled = false;
	}
	void FixedUpdate (){
		time += Time.deltaTime;
		switch((int)time){
			case 0: 
				GetComponent<TextMesh> ().text = "3";
				break;
			case 1: 
				GetComponent<TextMesh> ().text = "2"; 
				break;
			case 2: 
				GetComponent<TextMesh> ().text = "1"; 
				break;
			case 3: 
				GetComponent<TextMesh> ().text = ""; 
				ai_script.enabled = true;
				if(user_script != null)
					user_script.enabled = true;
				Behaviour itself = (Behaviour)GetComponent<TextMesh>().GetComponent("Countdown");
				itself.enabled = false;
				Behaviour timer = (Behaviour)GameObject.Find("Timer").GetComponent("Timer");
				timer.enabled = true;
				break;
		}
	}
}