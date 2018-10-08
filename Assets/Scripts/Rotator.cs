using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Rotation Settings")] [Tooltip("Sets the constant rotation of the main camera")]
    [SerializeField] float rotationSpeed = 30f;

    void RotateCamera()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed);
    }
	
	// Update is called once per frame
	void Update ()
    {
        RotateCamera();
	}
}
