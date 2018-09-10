using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed;
	GameObject player;
	Rigidbody2D r;
	Animator animator;
	int jumps = 0;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		r = player.GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		animator.SetBool("right", false);
		animator.SetBool("left", false);

		if (Input.GetKeyDown (KeyCode.Space)) {
			if (jumps < 1) {
				r.AddForce (Vector2.up * 300);
				jumps++;
			}
			else {
				jumps = 0;
			}
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			player.transform.position += (new Vector3(1,0,0) * speed * Time.deltaTime);
			animator.SetBool("right", true);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			player.transform.position -= (new Vector3(1,0,0) * speed * Time.deltaTime);
			animator.SetBool("left", true);
		}

	}
}
