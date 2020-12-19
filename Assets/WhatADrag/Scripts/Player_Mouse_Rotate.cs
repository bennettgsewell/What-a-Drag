using UnityEngine;
using System.Collections;

public class Player_Mouse_Rotate : MonoBehaviour {

	public Camera c;
	
	private Vector3 point = Vector3.zero;
	
	// Update is called once per frame
	void Update () {
		Ray camera_ray = c.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		
		if( Physics.Raycast( camera_ray, out hit, 100 ) ) {
			point = hit.point;
			point.y = transform.position.y;
			transform.LookAt(point);
		}
	}
}
