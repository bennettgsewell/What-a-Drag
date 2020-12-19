using UnityEngine;
using System.Collections;

public class Patrol_AI : MonoBehaviour {
	public float current_speed, default_speed = 6f, gravity = 10f;
	private CharacterController controller;
	
	public GameObject apple;
	
	private Vector3 direction;
	
	//Start
	void start(){
		current_speed = default_speed;
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		current_speed = default_speed;
		
		direction = (apple.transform.position - transform.position);
		//	move_direction = transform.TransformDirection(new Vector3(1f,0f,1f));
		direction *= current_speed;
		direction.y -= gravity * Time.deltaTime;
		if (controller.isGrounded) 
			controller.Move(direction * current_speed * Time.deltaTime);
		//controller.Move(move_direction * Time.deltaTime);
	}
}
