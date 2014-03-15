using UnityEngine;
using System.Collections;

public class bosluk : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.transform.name == "fpc") {
				
			Destroy(this);
			
			
		}


	}
}
