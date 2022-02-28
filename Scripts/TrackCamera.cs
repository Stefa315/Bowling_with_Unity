using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class TrackCamera : MonoBehaviour {
	public Ball ball;


	private Vector3 offset;


	// Use this for initialization
	void Start () {
		
		offset = transform.position - ball.transform.position;
	}

	// Update is called once per frame
	void Update () {


		if (ball.transform.position.z >= 6) {
			
			transform.position = new Vector3 (-10.8f,6,5);
		} else {
			
			this.transform.position = new Vector3 (transform.position.x, transform.position.y, ball.transform.position.z + offset.z);
		}

	
			
			

		}
	}


