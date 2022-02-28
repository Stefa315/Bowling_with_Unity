using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public bool inPlay = false;

	private Vector3 offse;
	private Vector3 ballstartPos;
	public Vector3 launchVelocity;
	private Rigidbody rb;
	private AudioSource audioSource;
	void Start()
	{
		
		rb = GetComponent<Rigidbody>();
		rb.useGravity = false;
		ballstartPos = transform.position;
	}
	public void Reset(){
		
		inPlay = false;
		rb.useGravity = false;
		transform.position = ballstartPos;
		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;

	}

	public void Launch(Vector3 velocity)
	{
		inPlay = true;
		rb.useGravity = true;
		rb.AddForce(0,0,velocity.z,ForceMode.Force);
		rb.velocity = velocity;
		//audioSource = GetComponent<AudioSource> ();
		//audioSource.Play ();
	}
		

}
