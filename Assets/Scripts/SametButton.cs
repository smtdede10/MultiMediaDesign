using UnityEngine;
using System.Collections;

public class SametButton : MonoBehaviour {

	public GameObject StartButton;
	public GameObject StopButton;
	public  bool StopBoolean;
	public  bool StartBoolean;

	// Use this for initialization
	void Start () {
		StartBoolean = true;
		StopBoolean = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray;
		RaycastHit hit;
		ray = Camera.main.ScreenPointToRay (new Vector3 (Screen.width/2,Screen.height/2,0));
		
		if (Physics.Raycast (ray, out hit, 10f)) {
			
			if(hit.transform.name=="Stop"&& StopBoolean==false)
			{

				if(Input.GetKeyDown (KeyCode.F)){
					StopBoolean = true;
					StartBoolean = false;
					StartButton.transform.localScale = new Vector3 (StartButton.transform.localScale.x, 3,StartButton. transform.localScale.z);
					StopButton.transform.localScale = new Vector3 (StopButton.transform.localScale.x, 1, StopButton.transform.localScale.z);
					RotationFan.yRotation = 0;
				}}
		
			if(hit.transform.name=="Start"&& StartBoolean==false)
			{
				if(Input.GetKeyDown (KeyCode.F)){
					StartBoolean = true;
					StopBoolean = false;
					StopButton.transform.localScale = new Vector3 (StopButton.transform.localScale.x, 3, StopButton.transform.localScale.z);
					StartButton.transform.localScale = new Vector3 (StopButton.transform.localScale.x, 1, StopButton.transform.localScale.z);
					RotationFan.yRotation = 6;
				}}
		}}
}
