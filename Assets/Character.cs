using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	Rigidbody2D charRB;

	[Header("CHARACTER MOVEMENT")]

	float hVelocity;
	[Range(0.01f, 5.0f)]
	public float hScale = .05f;
	[Header("horizontal")]

	float vVelocity;
	[Tooltip("Changes jump height")]
	[Range(0.5f, 20f)]
	public float jumpVal = 1.0f;

	[Tooltip("Let's us know when the character is on the ground")]
	public bool onGround;
	public float debounceTime = .25f;
	float jumpStartTime;
	public int jumps;
	// let's us know when character is on ground
	// Use this for initialization
	void Start () {
		charRB = gameObject.GetComponent<Rigidbody2D> ();
		vVelocity = 0;
		jumps = 0;

	}
	
	// Update is called once per frame
	void Update () {
		//horizontal movement
		getHorizontal ();
		getJump ();
		move ();
	}


	void getHorizontal(){
		hVelocity = Input.GetAxis ("Horizontal") * hScale * Time.deltaTime;
	}

	void move(){
		charRB.transform.position = new Vector2 (charRB.transform.position.x + hVelocity, charRB.transform.position.y);
		charRB.velocity += (Vector2.up * vVelocity);
	}

	//jump code
	void getJump(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (jumps == 1 && ((Time.time - jumpStartTime) > debounceTime)) {
				vVelocity = jumpVal * 1.5f;
				jumps++;
			}
			if (onGround) {
				vVelocity = jumpVal;
				jumpStartTime = Time.time;
				jumps++;
			} 
		}	

			else {
				vVelocity = 0;
			}

	
		}

	void OnTriggerEnter2D(Collider2D coll){
		if(coll.CompareTag("Ground")){
			if (!onGround) {
				onGround = true;
			}
				jumps = 0;
		}
	}

	void OnTriggerExit2D(Collider2D coll){
		if (coll.CompareTag ("Ground")) {
			if (onGround)	{
				onGround = false;
		}
		}
	}



}
