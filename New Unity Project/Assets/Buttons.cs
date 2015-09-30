using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Buttons : MonoBehaviour {

	GameObject aboutWindow;
	GameObject mainWindow;
	GameObject screen;
	float time;
	//float waitTime;
	float curTime;
	bool waited;

	//void Update(){
		//time = Time.deltaTime;
		//if (time > curTime + 60) {
		//	waited = true;
		//} else {
		//	waited = false;
		//}
	//}//

	IEnumerator MyMethod() {
		Debug.Log("Before Waiting 2 seconds");
		yield return new WaitForSeconds(2);
		Debug.Log("After Waiting 2 Seconds");
	}

	void test(){
		Application.LoadLevel ("infRun");
	}

	void remove(){
		aboutWindow.SetActive(false);
	}

	void Start(){
		aboutWindow = GameObject.Find ("/Canvas/p/About");
		mainWindow = GameObject.Find ("/Canvas/p/Menu");
		screen = GameObject.Find ("/Canvas/p");
	}

	public void restart(){
		Application.LoadLevel (Application.loadedLevelName);
	}

	public void menu(){

		Application.LoadLevel ("Main Menu");
	}

	public void sstart(){
		curTime = time;
		screen.GetComponent<Animation> ().Play("ST");
		//StartCoroutine (MyMethod ());
		//Application.LoadLevel ("infRun");
		Invoke ("test", 2);
	}

	public void about(){
		aboutWindow.SetActive(true);
		mainWindow.GetComponent<Animation>().Play("SLIDE");
		aboutWindow.GetComponent<Animation>().Play("SlideIn");
	}

	public void returnn(){
		aboutWindow.GetComponent<Animation>().Play("SLIDE");
		mainWindow.GetComponent<Animation>().Play("SlideIn");
		Invoke ("remove", 0.6f);

}
}



