using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KillScript : MonoBehaviour {

	public Vector3 startPoint = new Vector3 (0, 0, 0);
	Vector3 pos;

	public string level;
	//string score;
	int Score;
	bool died;
	public bool hscoreMade;
	

	public Transform Remains;
	public GameObject GameOverUI;
	Text ScoreText;
	Text hScoreText;
	GameObject Canvas;
	Transform pl;
	GameObject cam;

	//public Rigidbody rigBody;

	void Start() {
		GameOverUI = GameObject.Find("/Canvas/Died");
		//PlayerPrefs.SetInt("hscore",0);
		///Canvas = GameObject.Find ("/Canvas");
		ScoreText =  GameObject.Find("/Canvas/ScoreT").GetComponent<Text>();//.gameObject;
		hScoreText =  GameObject.Find("/Canvas/Score").GetComponent<Text>();//.gameObject;
	}

	void Update(){

		//ScoreText.text = "New Highscore! - " + Score;
		if (died) {
			hScoreText.text = "0";
			//died = false;
			pl.position = pos;
			//cam.transform.rotation = new Quaternion (359.7f,0,0,0);
			if (GameOverUI.transform.position.y < 0) {
				GameOverUI.transform.GetComponent<Animation>().Play("GameOverEnter");
				if(PlayerPrefs.GetInt("hscore") == 0){
				PlayerPrefs.SetInt("hscore",Score);
				}if(PlayerPrefs.GetInt("hscore") <= Score){
				PlayerPrefs.SetInt("hscore",Score);
					//ScoreText.text = "New Highscore! - " + Score;
					//Score = int.Parse (hScoreText.text);
					hscoreMade = true;
					ScoreText.GetComponent<Animation>().Play("hscore");
					if (hscoreMade == true) {
						//hscoreMade = false;
						ScoreText.text = "New Highscore! - " + Score;
					}


				}else{ScoreText.GetComponent<Animation>().Play("hscore");
					//if (hscoreMade == false) {
						ScoreText.text = "Highscore - " + PlayerPrefs.GetInt("hscore");


					//}
				}


			}

			}

		//if (hscoreMade == false) {
		//	ScoreText.text = "Highscore , " + PlayerPrefs.GetInt("hscore");
		//}

	}

	void OnTriggerEnter(Collider player){

		if (player.tag == "Player") {
			gameObject.transform.GetComponent<MeshRenderer>().enabled = false;
			pl = player.transform;
			pos = player.transform.position;
			died = true;
			player.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
			player.GetComponent<Rigidbody>().mass = 999999;
			Transform rem = Instantiate(Remains);
			rem.position = player.transform.position;
			player.GetComponent<MeshRenderer>().enabled = false;
			Score = int.Parse(hScoreText.text);
			//Destroy(pl);


		}

	}
}
