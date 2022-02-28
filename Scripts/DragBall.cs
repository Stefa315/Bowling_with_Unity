using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DragBall : MonoBehaviour {

  private Vector3 dragStart,dragEnd;
  private Ball ball;
  private float startTime,endTime;


	void Start () {
		ball = GetComponent <Ball> ();

	}
	  
	public void MoveStart(float amount){

		ball.transform.position = new Vector3 (ball.transform.position.x +amount,ball.transform.position.y, ball.transform.position.z);

	}


		public void DragStart(){
		dragStart = Input.mousePosition;
		startTime = Time.time;
		}


		public void DragEnd(){
		dragEnd = Input.mousePosition;
        endTime = Time.time;

         float dragDuration =endTime-startTime;
//		float launchSpeedZ=5;
//		float launchSpeedX = 2;
		float launchSpeedZ;
		if (( launchSpeedZ = (dragEnd.y-dragStart.y)*(dragDuration/1.5f)) > 45f) {
			//float launchSpeedZ= (dragEnd.y-dragStart.y)*dragDuration;
			launchSpeedZ = 45f;

		}

	    
		float launchSpeedX = (dragEnd.x - dragStart.x)/10f  ;
	
		Vector3 launchVelocity =new Vector3(launchSpeedX,0,launchSpeedZ);

		ball.Launch(launchVelocity);
	}

	}
	
	
