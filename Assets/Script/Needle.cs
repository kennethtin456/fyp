using UnityEngine;
using UnityEngine.UI;


public class Needle : MonoBehaviour {
	[SerializeField] private UnityStandardAssets.Vehicles.Car.CarController carController;
	float lastSpeed = 0;
	private void FixedUpdate(){
		float speed = carController.GetSpeed();
		transform.Rotate (Vector3.forward * -((speed - lastSpeed)*13));
		lastSpeed = speed;
	}
}
