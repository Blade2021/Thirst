using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {

	private Animator anim;
	public float speed;
	public bool isMoving;
	private Vector2 wasThere;
	//public Rigidbody2D rigid;

	void Start () {

		anim = GetComponent<Animator> ();
		
	}
	
	void Update () {

		isMoving = false;

		if (Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw ("Horizontal") < -0.5f) {
			transform.Translate (new Vector3(Input.GetAxisRaw ("Horizontal") * speed * Time.deltaTime, 0f, 0f));
			//rigid.velocity = sideways * speed;
			wasThere = new Vector2 (Input.GetAxisRaw ("Horizontal"), 0f);
			isMoving = true;
		}

		if (Input.GetAxisRaw ("Vertical") > 0.5f || Input.GetAxisRaw ("Vertical") < -0.5f) {
			transform.Translate (new Vector3(0f,Input.GetAxisRaw ("Vertical") * speed * Time.deltaTime, 0f));
			//rigid.velocity = longways * speed;
			wasThere = new Vector2 (0f, Input.GetAxisRaw ("Vertical"));
			isMoving = true;
		}


		anim.SetBool ("isMoving", isMoving);
		anim.SetFloat ("xInput", Input.GetAxisRaw ("Horizontal"));
		anim.SetFloat ("yInput", Input.GetAxisRaw ("Vertical"));
		anim.SetFloat ("wasTherey", wasThere.y);
		anim.SetFloat ("wasTherex", wasThere.x);
	}
		
}
