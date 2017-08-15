using UnityEngine;
using UnityEngine.UI;

public class NumLap : MonoBehaviour {
	TextMesh text;
	[SerializeField] Lap lap;
	void Start(){
		text = GetComponent<TextMesh>();
	}
	void Update(){
		text.text = "Lap " + Mathf.Ceil((float)lap.player_passed / (float)lap.num_checkpoint) + "/" + lap.num_lap;
	}
}
