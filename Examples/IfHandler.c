using UnityEngine;
using System.Collections;

public class IfHandler : MonoBehaviour {
    float testx = 10.0;
    float testy = 12.3;
    
    void Update ()
    {
    	if(Input.GetKeyDown(KeyCode.Space)){
    		LabTest();
    	}
    	testx = Time.detlaTime * 5f;
    }
    
    void LabTest()
    {
    	
    }
}