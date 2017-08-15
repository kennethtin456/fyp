using UnityEngine;
using UnityEngine.UI;

public class Map1TourCheckpoint : MonoBehaviour {
	[SerializeField] TextMesh tourMessage;
	void OnTriggerEnter(Collider other){
		switch (this.gameObject.name){
			case "checkpoint1":
				tourMessage.text = "<-Lingnan Stadium\nTrain Station->";
				break;
			case "checkpoint2":
				tourMessage.text = "";
				break;
			case "checkpoint3":
				tourMessage.text = "<-Yasumoto International Academic Park";
				break;
			case "checkpoint4":
				tourMessage.text = "<-Wu Ho Man Yuen Building\nAn Integrated Teaching Building->";
				break;
			case "checkpoint5":
				tourMessage.text = "Haddon-Cave Sports Field->";
				break;
			case "checkpoint6":
				tourMessage.text = "";
				break;
			case "checkpoint7":
				tourMessage.text = "University Gym->";
				break;
			case "checkpoint8":
				tourMessage.text = "S.H.HO College->";
				break;
			case "checkpoint9":
				tourMessage.text = "";
				break;
			case "checkpoint10":
				tourMessage.text = "Run Run Shaw Science Building->";
				break;
			case "checkpoint11":
				tourMessage.text = "<-William M.W. Mong Engineering Building\nRun Run Shaw Science Building->";
				break;
			case "checkpoint12":
				tourMessage.text = "<-Ho Sin-Hang Engineering Building";
				break;
			case "checkpoint13":
				tourMessage.text = "Lady Shaw Building->";
				break;
			case "checkpoint14":
				tourMessage.text = "";
				break;
			case "checkpoint15":
				tourMessage.text = "University Administration Building->";
				break;
			case "checkpoint16":
				tourMessage.text = "University Library->";
				break;
		}
	}
}