using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
		[SerializeField] private CardboardHead head;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
			
        }


        private void FixedUpdate()
        {
			
			Vector3 facing = head.transform.forward;
			//Debug.Log(facing.x+" "+facing.y+" "+facing.z);
            // pass the input to the car!
            //float h = CrossPlatformInputManager.GetAxis("Horizontal");
            //float v = CrossPlatformInputManager.GetAxis("Vertical");
			float v = facing.y * 0.3f;
			float h = 0;
			if(facing.x > 0.2 || facing.x < -0.2)
				h = facing.x;
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
