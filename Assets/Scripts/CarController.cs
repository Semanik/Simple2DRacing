using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public CarMover Car;
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Car.Accelerate();
        }

        if (Input.GetKey(KeyCode.D))
        {
            Car.RotateRight();
        }

        if (Input.GetKey(KeyCode.A))
        {
            Car.RotateLeft();
        }
		
	}
}
