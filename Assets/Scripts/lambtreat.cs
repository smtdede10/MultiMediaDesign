using UnityEngine;
using System.Collections;

public class lambtreat : MonoBehaviour {
	public PlayerScript myPly;
	public bool active;

	// Use this for initialization
	void Start () {
		active = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (active) {
			
			/*float radius=1f;
			float a=myPly.transform.localRotation.y-transform.localRotation.y;
			transform.RotateAround(myPly.transform.position,Vector3.up,a);
			
			Vector3 desiredPos=(transform.position - myPly.transform.position).normalized * radius + myPly.transform.position;
			
			transform.position = Vector3.MoveTowards(transform.position, desiredPos, Time.deltaTime );*/
			transform.position = myPly.transform.position + new Vector3(0.5f,0.5f,1);
		
	}

}
}
