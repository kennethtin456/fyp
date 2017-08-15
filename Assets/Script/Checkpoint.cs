using UnityEngine;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour {
	[SerializeField] Lap lap;
	
	void OnTriggerEnter(Collider other){
		string checkpoint = this.gameObject.name;
		int checkpoint_no = int.Parse(checkpoint[checkpoint.Length-1].ToString());
		lap.UpdateCheckpoint(other.gameObject.name, checkpoint_no);
	}
}