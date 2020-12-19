using UnityEngine;
using System.Collections;

public class Draggable_Object : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Physics.IgnoreCollision(GameObject.FindGameObjectWithTag("Player").GetComponent<Collider>(), GetComponent<Collider>());
		gameObject.tag = "draggable";
		GameObject[] gos = GameObject.FindGameObjectsWithTag("draggable");
		foreach (GameObject go in gos)
			if(go.GetComponent<Collider>()!=GetComponent<Collider>())
				Physics.IgnoreCollision(go.GetComponent<Collider>(), GetComponent<Collider>());
	}
}
