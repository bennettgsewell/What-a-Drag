using UnityEngine;
using System.Collections;

public class WinCondition : MonoBehaviour {

	public float winDistance = 3;

	void Update () {
		if(Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, transform.position) < winDistance)
			Application.LoadLevel("win");
	}
}
