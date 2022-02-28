using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public Pins[] geko;
	public Ball ballz;

	public GameObject cam;
	public int i,j;
	private int score;

	//public Text scorez;
	//public PinsScore Clue;
	private Vector3 pos;
	private int a;
	public PinsScore Clue;

	void Start () {
		i = 0;
		j = 0;
		//scorez.text = "WORLD IS BAD ";
		score = 0;
		Clue = GetComponent<PinsScore> ();
		pos = Camera.main.transform.position;
		a = 0;


	}




	void Update () {
		

			
			if (Input.GetKeyDown (KeyCode.Mouse0)){
				
				
				if(a==2){
				//cam.transform.position = new Vector3(-10.81,7.04,-22.49);
						i++;

				}
				if (i == 2) {
				
					j = 0;
					a = 0;
				}
				a += 1;
			}
			//TO A EINAI METAVLTHTH GIA NA METRAEI MIA FORA ME TO DEKSI KLIK KAI MAI FORA ANIMATION
		}



	}


		

	

