using UnityEngine;
using System.Collections;

public class WhatADragGame : MonoBehaviour {
	public static float playerDistanceFromCorpse(){
		GameObject d = GameObject.FindGameObjectWithTag("theCorpse").transform.Find("Hips").gameObject;
		GameObject p = GameObject.FindGameObjectWithTag("Player");
		
		return Vector3.Distance(d.transform.position, p.transform.position);
	}
	public static GameObject getCorpseHips(){
		return GameObject.FindGameObjectWithTag("theCorpse").transform.Find("Hips").gameObject;
	}
	public static GameObject getClosestOfficer(Vector3 v){
		GameObject[] officers = GameObject.FindGameObjectsWithTag("Police");
		float smallestDistance = Vector3.Distance(officers[0].transform.position, v);
		GameObject smallestOfficer = officers[0];
		foreach (GameObject officer in officers)
			if(Vector3.Distance(officer.transform.position, v) < smallestDistance) {
				smallestDistance = Vector3.Distance(officer.transform.position, v);
				smallestOfficer = officer;
			}
		return smallestOfficer;
	}
	
	public static float getCurrentDistanceFromCorpse(Vector3 v){
		GameObject d = GameObject.FindGameObjectWithTag("theCorpse").transform.Find("Hips").gameObject;
		
		return Vector3.Distance(d.transform.position, v);
	}
	
	
		
	public static float playerDistanceFromHere(Vector3 v){
		GameObject d = GameObject.FindGameObjectWithTag("Player").gameObject;
		
		return Vector3.Distance(d.transform.position, v);
	}
}
