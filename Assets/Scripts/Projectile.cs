using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public GameObject projectile, powerMeter, invisCol;
	GameObject obj,meter;

	GameObject bar;
	int power;
	static public int speed;

	public GameObject lose;
	public GameObject stick;
	public GameObject stickClimbing;
	public GameObject stickFalling;
	public GameObject splash;
	public GameObject win;

	void Start() {
		lose.gameObject.SetActive (false);
		stickClimbing.gameObject.SetActive (false);
		stickFalling.gameObject.SetActive (false);
		splash.gameObject.SetActive (false);
		win.gameObject.SetActive (false);
		projectile.GetComponent<CircleCollider2D> ().enabled = false;
	}

	void OnMouseDown() {
		invisCol.GetComponent<BoxCollider2D> ().enabled = false;
		obj = Instantiate (projectile, transform.position, Quaternion.identity) as GameObject;
		meter = Instantiate(powerMeter, new Vector2(transform.position.x, transform.position.y + 2.5f),Quaternion.identity) as GameObject;
		bar = GameObject.Find ("Bar");
		int num = Random.Range (0, 2);
		if (num == 0) {
			bar.GetComponent<Animator> ().runtimeAnimatorController = Resources.Load ("Animation/Bar (slow)") as RuntimeAnimatorController;
		} else {
			bar.GetComponent<Animator> ().runtimeAnimatorController = Resources.Load ("Animation/Bar") as RuntimeAnimatorController;
		}
	}

	void OnMouseUp() {
		float barPos = bar.transform.position.y;

		obj.GetComponent<CircleCollider2D> ().enabled = true;
		//bar = GameObject.Find ("Bar");
		if (bar.transform.position.y < -1.5f) {
			speed = 5;
			invisCol.GetComponent<BoxCollider2D> ().enabled = true;
		} else if (barPos >= -1.5f && barPos < -0.9f) {
			speed = 5;
		} else if (barPos >= -0.9f && barPos < -0.2f) {
			speed = 7;
		} else if (barPos > -0.2f) {
			speed = 10;
			obj.GetComponent<CircleCollider2D> ().enabled = false;
		}
		Debug.Log ("position = " + barPos.ToString ());
		obj.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 1) * speed;
		Destroy (meter.gameObject);
	}




}
