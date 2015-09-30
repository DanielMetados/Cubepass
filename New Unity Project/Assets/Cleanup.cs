using UnityEngine;
using System.Collections;

public class Cleanup : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Ob"){
			Destroy(other.gameObject);
		}
	}
}
