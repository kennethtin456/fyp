using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	float time;
	TextMesh text;
	void Start(){
		text = GetComponent<TextMesh>();
	}
	void Update(){
		time += Time.deltaTime;
		text.text = "Time " + ((int)(time/60)).ToString() + ":" + ((int)(time%60)).ToString() + ":" + ((int)((time%60%1)/0.01)).ToString();
	}
}
