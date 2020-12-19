using UnityEngine;
using System.Collections;

public class ResetCamera : MonoBehaviour {
	
	void OnMouseDown(){
		Vector3 v = GameObject.FindGameObjectWithTag("camera").transform.position;
		v.x = 0;
		GameObject.FindGameObjectWithTag("camera").transform.position = v;
	}
}
