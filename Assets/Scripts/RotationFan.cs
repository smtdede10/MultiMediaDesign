using UnityEngine;
using System.Collections;

public class RotationFan : MonoBehaviour {

	public static float yRotation;
	// Use this for initialization
	void Start () {
		yRotation = 6.0f;
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (new Vector3 (0,0,yRotation));

	
	}
}
