using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pins : MonoBehaviour {
	public bool Sta;
	public GameObject pin;
	private Vector3 pol;
	private Rigidbody rb;
	// Use this for initialization

	void Start () {
		pol = transform.position;
		rb = GetComponent<Rigidbody>();
	}



	public bool IsStanding(){
		bool Sta = true;

		//Vector3 rotationInEuler = transform.rotation.eulerAngles;

		if(transform.rotation.w < 0.5f) {
			
			Sta = false;
			return Sta;

		}
			
	        
			return Sta;
			}
	public void Reset (){
		transform.position = pol;
		transform.rotation = new Quaternion (0, 0, 0, 1);
		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;

		Debug.Log ("ggahan");


	}
	}





