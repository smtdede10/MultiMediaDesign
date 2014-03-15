using UnityEngine;
using System.Collections;

public class button_thread : MonoBehaviour {

	public button_thread other_btn;
	public PlayerScript myPly;

	float active,pasive;
	public bool isActive;

	// Use this for initialization
	void Start () {
		active = 3f;
		pasive = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray;
		RaycastHit hit;
		ray = Camera.main.ScreenPointToRay (new Vector3 (Screen.width/2,Screen.height/2,0));

		if (Physics.Raycast (ray, out hit, 10f)) {
				
			if(hit.transform.name=="Start"||hit.transform.name=="Stop")
			{
				if(Input.GetKeyDown (KeyCode.F)){

				if (isActive) {
					isActive = !isActive;
					
					transform.localScale = new Vector3 (transform.localScale.x, active, transform.localScale.z);
					other_btn.transform.localScale = new Vector3 (other_btn.transform.localScale.x, pasive, other_btn.transform.localScale.z);
					
				} else {
					
					isActive = !isActive;
					transform.localScale = new Vector3 (transform.localScale.x, pasive, transform.localScale.z);
					other_btn.transform.localScale = new Vector3 (other_btn.transform.localScale.x, active, other_btn.transform.localScale.z);
				}

				}

			}
			
			
		}



	
	}


	void OnMouseDown(){



	}




	//Ray ray;
	//RaycastHit hit;

	//if (Physics.Raycast ( ray,out hit, 10f)) {
	//	if()


	//}

}
