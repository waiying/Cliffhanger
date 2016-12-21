using UnityEngine;
using System.Collections;

public class InvisibleCollider : MonoBehaviour {
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
		if (other.name == "Rock1(Clone)") {
			other.GetComponent<Rigidbody2D> ().gravityScale = 1f;
			other.GetComponent<CircleCollider2D> ().enabled = false;
			Destroy (other.gameObject,3f);
		}
	
	}
}
