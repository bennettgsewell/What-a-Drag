//

using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {
	public float current_speed, default_speed = 6f, gravity = 10f;
	private Vector3 move_direction = Vector3.zero;
	public GameObject bodyWithAnimator;
	//Start
	void start(){
		current_speed = default_speed;
	}
	
	// Update is called once per frame
	void Update () {
		current_speed = default_speed;
	
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) 
			move_direction = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
		Animator a =  bodyWithAnimator.GetComponent<Animator>();
		if(Input.GetAxis("Horizontal")!=0||Input.GetAxis("Vertical")!=0)
			a.SetBool("walking",true);
		else 
			a.SetBool("walking",false);
		move_direction *= current_speed;
		move_direction.y -= gravity * Time.deltaTime;
		controller.Move(move_direction * Time.deltaTime);
		
	}
}
