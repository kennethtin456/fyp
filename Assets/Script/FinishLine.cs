using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour {
	void OnTriggerEnter(){
		Debug.Log("Finish!!");
		Behaviour timer = (Behaviour)GameObject.Find("Timer").GetComponent("Timer");
		timer.enabled = false;
		Behaviour car = (Behaviour)GameObject.Find("Car").GetComponent("CarUserControl");
		car.enabled = false;
	}
}