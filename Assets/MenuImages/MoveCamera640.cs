using UnityEngine;
using System.Collections;

public class MoveCamera640 : MonoBehaviour {
	
	void OnMouseDown(){
		Vector3 v = GameObject.FindGameObjectWithTag("camera").transform.position;
		v.x += 640;
		GameObject.FindGameObjectWithTag("camera").transform.position = v;
	}
}
