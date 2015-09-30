using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {
	public float speed =1f;
	public float score = 0f;
	public int multiplierScore = 1;
	public Text scoreText;
	public bool started;
	bool readyToJump;
	public int force = 600;

	public bool Mobile = false;
	public int pcSpeedDiv = 5;

	void Start() {

	}

	void Update () {
		if (Input.GetMouseButtonDown (0) == true && started == false){
			transform.GetComponent<Rigidbody> ().AddForce (0, 0, force);
			started = true;
		}

		if (started == true) {
			if(Input.GetMouseButtonDown(0) == true && transform.position.y <  0.38f && readyToJump){
				transform.GetComponent<Rigidbody>().AddForce(0,force,0);
				//transform.GetComponent<Rigidbody>().AddTorque(40,0,0);

			}//else if(Input.GetKeyDown("Jump") == true && transform.position.y <  0.38f && readyToJump && !Mobile){
				//	transform.GetComponent<Rigidbody>().AddForce(0,force,0);
					//transform.GetComponent<Rigidbody>().AddTorque(40,0,0);
					//}

			readyToJump = true;
			transform.GetComponent<Rigidbody> ().AddForce (0, 0, speed/10);
			score = score + (Time.deltaTime * 100 * multiplierScore);
			scoreText.text = (Mathf.Ceil (score)).ToString ();

			if(Mobile){
				transform.Translate (Input.acceleration.x, 0, 0);
			}else if(!Mobile){
				transform.Translate (Input.GetAxis ("Horizontal")/pcSpeedDiv, 0, 0);
			}
		}
	}
}
