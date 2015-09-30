using UnityEngine;
using System.Collections;

public class ClickMenu : MonoBehaviour {

	public string ani;
	public string level;
	bool pressed;
	float timePres = 0;
	float timePast = 0;


	void OnMouseDown(){
		transform.GetComponent<Animation> ().Play (ani);
		pressed = true;
	}

	void Update(){
		timePres = timePres+Time.deltaTime*40;
		if (timePres > timePast + 0.5 * 7000 * Time.deltaTime && pressed) {
			Application.LoadLevel(level);
		}
	}
}
