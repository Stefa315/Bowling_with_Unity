using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinsScore : MonoBehaviour {
	
	public Text jikes;
	public int DefScore=-1;
	private int a;

	private float lastChangeTime;
	private float firstCollideTime;

	private bool ballEntered;
	private int score1,score2;
	public Ball ball;
	public Pins pins;

	public int b;

	// Use this for initialization
	void Start () {
		ballEntered = false;

//		ball =  GameObject.FindObjectOfType<Ball> ();
		//ball =GetComponent<Ball> ();

	}
	
	// Update is called once per frame
	void Update () {





		jikes.text = (score1.ToString()+ "-" +score2.ToString());

		if (ballEntered) {
			
			CheckStanding ();

		}

		}

	public int  Multiplayer(int b){
		return b;

	}
	public int Solo(int b){
		return b;
	}




	public void PinsHaveSettled(){
		a += 1;
		DefScore = -1;  //arxikopoiw to score gia ton epomeno
		if ((a == 1) || (a == 2)) {
			jikes.color = Color.blue;
			score1 += CountFallen ();
			//Debug.Log ("dFDE"+score1);
			jikes.text =( score1.ToString () +"-"+ score2.ToString());
		} else {
			Debug.Log (a + "fag");
			jikes.color = Color.green;
			score2 += CountFallen ();
			jikes.text = score1.ToString () + score2.ToString ();

		}
		if(a==4){
			a=0;
		}
		ballEntered = false;

		ball.Reset ();
		foreach (Pins pins in GameObject.FindObjectsOfType<Pins>()) {
			
				pins.Reset ();
				//Debug.Log (count+"GGGEFD");
			}


		}


	public void CheckStanding(){
		
		int currentStanding = CountFallen ();

		if (currentStanding != DefScore) {
			lastChangeTime = Time.time;
			DefScore = currentStanding;
			return;
		}
		float SettleTime=3f;//3 seconds perimeneis afotoy pesei h prwth korina 
		if ((Time.time - lastChangeTime) > SettleTime) {
			
			PinsHaveSettled ();
		}
	}




	int CountFallen (){
		int count = 0;
		foreach (Pins pins in GameObject.FindObjectsOfType<Pins>()) {
			if (!pins.IsStanding ()) {
				count++;
				//Debug.Log (count+"GGGEFD");
			}


		}
	
		return count;
	}




	void OnTriggerEnter(Collider collider){
	 GameObject xtyphse = collider.gameObject;
		firstCollideTime = Time.time;

		if (xtyphse.GetComponent<Ball>()) {
			
			ballEntered = true;

			jikes.color = Color.red;
		}
		return;
		}


	void OnTriggerDestroy(Collider collider){
		GameObject pinleft = collider.gameObject;

		if (pinleft.GetComponent<Pins> ()) {
			
			print ("FTASAME");
		Destroy (pinleft);

		}
	}

}



	//END

