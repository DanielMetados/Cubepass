using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class hscoreMainMenu : MonoBehaviour {



	void Update () {
		gameObject.transform.GetComponent<Text> ().text = "Highscore : " + PlayerPrefs.GetInt ("hscore");
	}
}
