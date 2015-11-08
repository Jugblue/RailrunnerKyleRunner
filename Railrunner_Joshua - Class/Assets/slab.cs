using UnityEngine;
using System.Collections;

public class slab : MonoBehaviour
{
	public Transform downEndpoint;
	public Transform upEndpoint;
	public float speed = 0.1f;

	private int direction = 1;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate (direction * speed, 0, 0);
		
		if (transform.position.y <= downEndpoint.localPosition.y) {
			direction = -1;
			
		} else if (transform.position.y >= upEndpoint.localPosition.y)
			direction = 1;
	}

	
}

