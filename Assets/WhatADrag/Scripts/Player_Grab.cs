using UnityEngine;
using System.Collections;

public class Player_Grab : MonoBehaviour {

	public Camera c;
	public float minPickUpDistance = 4f;
	
	
	private SpringJoint hands;

	

	void Start(){
		hands = GetComponent<SpringJoint>();
	}

	void Update(){
		if(Input.GetMouseButtonDown(0)){
			Ray camera_ray = c.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if( Physics.Raycast( camera_ray, out hit, 100 ) )
				grab(hit.transform.gameObject);
				
			
		}
	}
	
	void grab(GameObject g){
		if(g!=null && g.tag == "draggable" && Vector3.Distance(g.transform.position, transform.position)<=minPickUpDistance) {
			hands.connectedBody = g.GetComponent<Rigidbody>();
		} else
			hands.connectedBody = null;
	}
}
