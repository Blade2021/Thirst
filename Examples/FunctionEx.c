using UnityEngine;
using System.Collections;

public class FunctionExample : MonoBehaviour
{
	int x = 5;
	
	void Start()
	{
		x = MultiplyByTwo(x);
		Debug.log(x);
	}
	
	int MultiplyByTwo (int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}
}|