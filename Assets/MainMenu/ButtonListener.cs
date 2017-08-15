using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonListener : MonoBehaviour 
{
	GameObject a;
	GameObject c;
	public Text textSelected;
	public void PlayButton (GameObject obj)
	{
		
		GameObject a = obj.transform.Find("Racing").gameObject;
		GameObject c = obj.transform.Find("Tour").gameObject;
		GameObject e = obj.transform.Find("Exit").gameObject;
		
		if(a.activeSelf == false){
			a.SetActive(true);
			c.SetActive(true);
			Vector3 tempPos = e.transform.position;
			tempPos.y -= 1.84f;
			e.transform.position = tempPos;
		}
		else{
			a.SetActive(false);
			c.SetActive(false);
			Vector3 tempPos = e.transform.position;
			tempPos.y += 1.84f;
			e.transform.position = tempPos;
		}
	}
	
	public void RacingButton(){
		Application.LoadLevel("MapMenu");
	}
	public void TourButton(){
		Application.LoadLevel("TourMapMenu");
	}
	public void ExitButton(){
		Application.Quit();
	}
	public void Map1Button(){
		GameObject canvas = GameObject.Find("/Canvas");
		GameObject img1 = canvas.transform.Find("Img1").gameObject;
		GameObject img2 = canvas.transform.Find("Img2").gameObject;
		GameObject go = canvas.transform.Find("Go").gameObject;
		img1.SetActive(true);
		img2.SetActive(false);
		go.SetActive(true);
	}
	public void Map2Button(){
		GameObject canvas = GameObject.Find("/Canvas");
		GameObject img1 = canvas.transform.Find("Img1").gameObject;
		GameObject img2 = canvas.transform.Find("Img2").gameObject;
		GameObject go = canvas.transform.Find("Go").gameObject;
		img1.SetActive(false);
		img2.SetActive(true);
		go.SetActive(true);
	}
	public void BackButton(){
		Application.LoadLevel("MainMenu");
	}
	
	public void GoButton(){
		GameObject canvas = GameObject.Find("/Canvas");
		GameObject img1 = canvas.transform.Find("Img1").gameObject;
		GameObject img2 = canvas.transform.Find("Img2").gameObject;
		if(img1.activeSelf == true){
			Application.LoadLevel("Map1");
		}
		else if(img2.activeSelf == true){
			Application.LoadLevel("Map2");
		}
	}
	public void Map1TourButton(){
		GameObject canvas = GameObject.Find("/Canvas");
		GameObject img1 = canvas.transform.Find("Img1").gameObject;
		GameObject img2 = canvas.transform.Find("Img2").gameObject;
		GameObject go = canvas.transform.Find("GoTour").gameObject;
		img1.SetActive(true);
		img2.SetActive(false);
		go.SetActive(true);
	}
	public void Map2TourButton(){
		GameObject canvas = GameObject.Find("/Canvas");
		GameObject img1 = canvas.transform.Find("Img1").gameObject;
		GameObject img2 = canvas.transform.Find("Img2").gameObject;
		GameObject go = canvas.transform.Find("GoTour").gameObject;
		img1.SetActive(false);
		img2.SetActive(true);
		go.SetActive(true);
	}
	public void GoTourButton(){
		GameObject canvas = GameObject.Find("/Canvas");
		GameObject img1 = canvas.transform.Find("Img1").gameObject;
		GameObject img2 = canvas.transform.Find("Img2").gameObject;
		if(img1.activeSelf == true){
			Application.LoadLevel("Map1Tour");
		}
		else if(img2.activeSelf == true){
			Application.LoadLevel("Map2Tour");
		}
	}
	public void MyClick (GameObject obj) 
	{
		Text text = obj.GetComponentInChildren<Text>();
		textSelected.text = "You selected " + (text != null ? text.text : obj.name);
		Debug.Log (textSelected.text);


		// Find input field
		InputField[] ins = GameObject.FindObjectsOfType<InputField>();
		foreach (InputField i in ins)
		{
			Debug.Log ("in: " + i.name);
			if (i.isFocused)
			{//i.Select();   // I also tried to use this EventSystem.current.SetSelectedGameObject(go);
				i.ActivateInputField();
				i.Select();
				i.MoveTextEnd(false);
				i.ProcessEvent(Event.KeyboardEvent("b"));
//				inputField.ProcessEvent(Event.KeyboardEvent("a"));
//				i.text += "a";
//				i.textComponent.text += "a";
			}
		}
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			GameObject go = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
			if (go != null)
			{
				InputField i = go.GetComponent<InputField>();
				if (i != null)
				{
					i.ProcessEvent(Event.KeyboardEvent("l"));
				}
			}
		}
	}
}
