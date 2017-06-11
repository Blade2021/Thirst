using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour {
	
	public float slowTime = 0.15f;
	private Vector3 speed = Vector3.zero;
	public Transform Character;
	private Camera cam;

	void Start () {
		cam = GetComponent<Camera> ();
		
		
	}

	private void FixedUpdate (){
		//if (Character) {

		//	Vector3 point = cam.WorldToViewportPoint (Character.position);
		//	Vector3 delta = Character.position - cam.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, point.z));
		//	Vector3 destination = transform.position + delta;
		//	transform.position = Vector3.SmoothDamp (transform.position, destination, ref speed, slowTime);
		//}
	}
	
	void Update () {
		if (Character) {

			Vector3 point = cam.WorldToViewportPoint (Character.position);
			Vector3 delta = Character.position - cam.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, point.z));
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp (transform.position, destination, ref speed, slowTime);
		}


	}
}
