using UnityEngine;
using UnityEngine.UI;

public class Map2TourCheckpoint : MonoBehaviour {
	[SerializeField] TextMesh tourMessage;
	void OnTriggerEnter(Collider other){
		switch (this.gameObject.name){
			case "checkpoint1":
				tourMessage.text = "Train Station->";
				break;
			case "checkpoint2":
				tourMessage.text = "";
				break;
			case "checkpoint3":
				tourMessage.text = "Yasumoto International Academic Park->";
				break;
			case "checkpoint4":
				tourMessage.text = "";
				break;
			case "checkpoint5":
				tourMessage.text = "<-Lake Ad Excellentiam";
				break;
			case "checkpoint6":
				tourMessage.text = "<-Lake Ad Excellentiam\nChung Chi Tang->";
				break;
			case "checkpoint7":
				tourMessage.text = "<-Lake Ad Excellentiam\nPommerenke Student Centre->";
				break;
			case "checkpoint8":
				tourMessage.text = "Elisabeth Luce Moore Library->";
				break;
			case "checkpoint9":
				tourMessage.text = "";
				break;
			case "checkpoint10":
				tourMessage.text = "<-Lingnan Stadium";
				break;
			case "checkpoint11":
				tourMessage.text = "<-Lingnan Stadium\nChung Chi College Administration Building->";
				break;
			case "checkpoint12":
				tourMessage.text = "<-Lingnan Stadium\nEsther Lee Building->";
				break;
			case "checkpoint13":
				tourMessage.text = "<-Lingnan Stadium";
				break;
			case "checkpoint14":
				tourMessage.text = "<-Lingnan Stadium\nTrain Station->";
				break;
		}
	}
}