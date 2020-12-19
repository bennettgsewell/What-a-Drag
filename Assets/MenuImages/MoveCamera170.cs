using UnityEngine;
using System.Collections;

public class MoveCamera170 : MonoBehaviour {

	void OnMouseDown(){
		Vector3 v = GameObject.FindGameObjectWithTag("camera").transform.position;
		v.x += 160;
		GameObject.FindGameObjectWithTag("camera").transform.position = v;
	}
}
