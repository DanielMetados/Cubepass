using UnityEngine;
using System.Collections;

public class camTilt : MonoBehaviour {




	void Update () {
		if (Mathf.Abs (-Input.acceleration.x) < 1*(Mathf.PI/180)) {
			transform.rotation = new Quaternion (transform.rotation.x, transform.rotation.y, 0, 5);
		} else {
			transform.rotation = new Quaternion (transform.rotation.x, transform.rotation.y, -Input.acceleration.x, 5);
		}
	}
}
