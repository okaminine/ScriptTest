using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour{

	void Start(){

		int[] points = new int[5];

		points [0] = 10;
		points [1] = 20;
		points [2] = 30;
		points [3] = 40;
		points [4] = 50;

		for (int i = 4; i >= 0; i--) 
		{
			Debug.Log (points [i]);
		}
	}


	// Update is called once per frame
	void Update () {
	}

	}
