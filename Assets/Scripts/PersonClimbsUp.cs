using UnityEngine;
using System.Collections;

public class PersonClimbsUp : MonoBehaviour {

	public GameObject lose;
	public GameObject stick;
	public GameObject stickClimbing;

	void Update(){
		Debug.Log ("lala" + GettingHit.power);
		if(GettingHit.power == 100){
			//Debug.Log (GettingHit.power);
			stickClimbing.gameObject.SetActive (true);
			Destroy (stick.gameObject);
			lose.gameObject.SetActive (true);
		}
	}

}
