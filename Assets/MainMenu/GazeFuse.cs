using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GazeFuse : MonoBehaviour 
{
	public Button button;
	private Image image;

	[Header("Gaze Settings")]
	public float GazeTimeInSeconds = 2f;
	private float startTime;
	// Current gazed at object and gaze time progress
	public static float gazeFraction { get; private set; }

	public int status = 0;
	void Start() 
	{
		image = GetComponent<Image>();
		gazeFraction = 0;
	}
	
	public void Enter(Button obj) 
	{
		button = obj;
		status = 1;
		startTime = Time.realtimeSinceStartup;
	}

	public void Exit()
	{
		status = 0;
		gazeFraction = 0;
		
	}
	void Update(){
		if(status == 1){
			gazeFraction = (Time.realtimeSinceStartup-startTime) / GazeTimeInSeconds;
			if(gazeFraction >= 1.0f){
				GameObject canvas = GameObject.Find("/Canvas");
				status = 0;
				gazeFraction = 0;
				if(button.name == "Play"){
					GameObject panel = canvas.transform.Find("Panel").gameObject;
					canvas.GetComponent<ButtonListener>().PlayButton(panel);
				}
				else if(button.name == "Racing"){
					canvas.GetComponent<ButtonListener>().RacingButton();
				}
				else if(button.name == "Tour"){
					canvas.GetComponent<ButtonListener>().TourButton();
				}
				else if(button.name == "Exit"){
					canvas.GetComponent<ButtonListener>().ExitButton();
				}
				else if(button.name == "Map1"){
					canvas.GetComponent<ButtonListener>().Map1Button();
				}
				else if(button.name == "Map2"){
					canvas.GetComponent<ButtonListener>().Map2Button();
				}
				else if(button.name == "Back"){
					canvas.GetComponent<ButtonListener>().BackButton();
				}
				else if(button.name == "Go"){
					canvas.GetComponent<ButtonListener>().GoButton();
				}
				else if(button.name == "Map1Tour"){
					canvas.GetComponent<ButtonListener>().Map1TourButton();
				}
				else if(button.name == "Map2Tour"){
					canvas.GetComponent<ButtonListener>().Map2TourButton();
				}
				else if(button.name == "GoTour"){
					canvas.GetComponent<ButtonListener>().GoTourButton();
				}
			}
		}
		FuseAmountChanged(gazeFraction);
	}
	void FuseAmountChanged(float fuseAmount)
	{
		if (image != null)
		{
			image.fillAmount = fuseAmount;
		}
	}

}
