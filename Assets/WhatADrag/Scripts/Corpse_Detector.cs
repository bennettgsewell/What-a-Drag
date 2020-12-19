using UnityEngine;
using System.Collections;

public class Corpse_Detector : MonoBehaviour {
	
	public Camera c;
	public float range = 4;
	
	private GameObject[] target;
	private GameObject current;
	
	void Start(){
		target = GameObject.FindGameObjectsWithTag("corpse");
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		
		if(Vector3.Distance(transform.position, target[0].transform.position) < range)
			if(Physics.Raycast(transform.position, (target[0].transform.position - transform.position), out hit, range)) {
				current = hit.transform.gameObject;
				do {
					if(current.tag=="theCorpse") {
						Debug.Log("WIN");
						return;
				}
				if(current.transform == null)
					return;
				if(current.transform.parent == null)
					return;
				if(current.transform.parent.gameObject == null)
					return;
					current = current.transform.parent.gameObject;
				} while(current != null);
			}
	}
}
