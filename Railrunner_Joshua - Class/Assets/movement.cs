using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour
{
	public Rigidbody body;
	public float speed = 5.0f;
	public float jumpHeight = 1.0f;
	Vector3 standardMovement;
	Vector3 jumpMovement;
	public bool isGrounded = true;

	// Use this for initialization
	void Start ()
	{
		standardMovement = new Vector3 (0.0f, 0.0f, speed);
		jumpMovement = new Vector3 (0.0f, jumpHeight, speed);
		body = GetComponent <Rigidbody> ();
		body.velocity = standardMovement;
	
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		isGrounded = Physics.Raycast (transform.position, Vector3.down, 1.0f);
		//Boost

		//Left Right
		if (isGrounded && Input.GetKey (KeyCode.Space)) {
			body.velocity = jumpMovement;
		} else if (isGrounded) {
			body.velocity = standardMovement;
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			transform.Translate (-2, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			transform.Translate (2, 0, 0);
		}


	}
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Obstacle") {
			Application.LoadLevel ("Main Scene");
		}
	


	}
}