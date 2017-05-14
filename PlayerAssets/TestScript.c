using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour
{
	public GameObject other;
	
	void Update(){
		if(Input.GetKey(KeyCode.Space))
		{
			Destroy(other);
		}
	}
}