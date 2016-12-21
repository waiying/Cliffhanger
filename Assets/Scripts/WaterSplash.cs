using UnityEngine;
using System.Collections;

public class WaterSplash : MonoBehaviour {

	public GameObject splash;
	public GameObject win;
	public GameObject stick;
	public GameObject stickFalling;

	void Update(){
		if (GettingHit.power == 0) {
			stickFalling.gameObject.SetActive (true);
			Destroy (stick.gameObject);
			splash.gameObject.SetActive (false);
		}
	}

	void OnTriggerEnter2D (Collider2D person) {
		if (person.gameObject.name == "Falling") {
			splash.gameObject.SetActive (true);
			Destroy (splash.gameObject, 0.5f);
			win.gameObject.SetActive (true);
		}
	}
}
