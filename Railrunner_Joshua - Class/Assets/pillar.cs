using UnityEngine;
using System.Collections;

public class pillar : MonoBehaviour
{
	public Transform rightEndpoint;
	public Transform leftEndpoint;
	public float speed = 0.01f;

	private int direction = 1;

	// Use this for initialization
	void Start ()
	{
	}

	
	// Update is called once per frame
	public void Update ()
	{
		transform.Translate (direction * speed, 0, 0);
			
		if (transform.position.x >= rightEndpoint.localPosition.x) {
			direction = -1;
				
		} else if (transform.position.x <= leftEndpoint.localPosition.x)
			direction = 1;
	}

}
	
	

