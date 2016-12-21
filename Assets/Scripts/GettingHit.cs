using UnityEngine;
using System.Collections;

public class GettingHit : MonoBehaviour {

	static public float power;

	void Start() {
		power = 50f;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
		if (other.name == "Rock1(Clone)") {
			Destroy (other.gameObject);
			if (Projectile.speed == 5) {
				power -= 5f;
			} else if (Projectile.speed == 7) {
				power -= 15f;
			}
		}
	}
}
