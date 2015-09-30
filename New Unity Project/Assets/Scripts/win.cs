using UnityEngine;
using System.Collections;

public class win : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Application.LoadLevel("Main Menu");
		}
	}
}
