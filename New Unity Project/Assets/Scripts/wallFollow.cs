using UnityEngine;
using System.Collections;

public class wallFollow : MonoBehaviour {

	public Transform player;


	void Update () {
		transform.position = new Vector3 (transform.position.x, transform.position.y, player.position.z);
	}
}
