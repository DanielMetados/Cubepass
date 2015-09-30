using UnityEngine;
using System.Collections;

public class Stop : MonoBehaviour {

	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.LoadLevel (0);
		}
	}
}
