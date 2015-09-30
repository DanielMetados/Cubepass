using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClosePass : MonoBehaviour {

	//public PlayerScript pScript;
	GameObject p;
	PlayerScript pScript;
	Text multScoreText;
	GameObject canvas;

	void Start(){
		canvas = GameObject.Find ("Canvas");
		multScoreText = canvas.transform.FindChild("multScore").gameObject.GetComponent<Text>();
		p = GameObject.Find ("Player");
		pScript = p.GetComponent<PlayerScript> ();
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			pScript.multiplierScore = pScript.multiplierScore + 1;
			multScoreText.GetComponent<Animation>().Play("mAnim1");
			multScoreText.text= "x"+pScript.multiplierScore.ToString();
		}

	}
}
