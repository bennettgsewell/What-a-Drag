using UnityEngine;
using System.Collections;

public class Draggable_Object : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Physics.IgnoreCollision(GameObject.FindGameObjectWithTag("Player").collider, collider);
		gameObject.tag = "draggable";
		GameObject[] gos = GameObject.FindGameObjectsWithTag("draggable");
		foreach (GameObject go in gos)
			if(go.collider!=collider)
				Physics.IgnoreCollision(go.collider, collider);
	}
}
