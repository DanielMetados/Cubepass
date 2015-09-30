using UnityEngine;
using System.Collections;

public class ObGenerate : MonoBehaviour {

	public Transform Ob;
	public Transform player;
	PlayerScript pScript;
	float zPos = 0;
	public float timePres = 0;
	public float timePast = 0;

	void Start(){
		//player = transform.Find ("Player");
		pScript = player.GetComponent<PlayerScript> ();

	}


	void Update () {
		if(pScript.started == true){
		timePres = timePres+Time.deltaTime*40;
		if (timePres > timePast + 0.5*40*Time.deltaTime) {
			if(player.position.z > zPos){
				zPos = player.position.z;
					timePast = timePres;
					Transform obstacle = Instantiate (Ob);
					obstacle.position = new Vector3 (Random.Range (-300, 300), 0, Random.Range (zPos+50, zPos+300));
					obstacle.localScale = new Vector3 (Random.Range(2,13), Random.Range (1,20), 2.5f);
				}
			}
		}
	}
}
