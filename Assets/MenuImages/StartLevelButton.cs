using UnityEngine;
using System.Collections;

public class StartLevelButton : MonoBehaviour {

	void OnMouseDown() {
		Application.LoadLevel("level");
	}
}
