using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour{

	void Start(){

		// 要素数5の配列を初期化する
		int[] points = new int[5];

		// 配列の各要素に値を代入する
		points [0] = 30;
		points [1] = 20;
		points [2] = 50;
		points [3] = 10;
		points [4] = 80;

		// 配列の要素をすべて表示する
		for (int i = 0; i < 5; i++) {
			Debug.Log (points [i]);
		}

		// 配列の要素をすべて表示する
		for (int i = 4; i >= 0; i--) {
			Debug.Log (points [i]);
		}

//		int[] pointsb = new int[5];

//		pointsb [0] = 10;
//		pointsb [1] = 20;
//		pointsb [2] = 30;
//		pointsb [3] = 40;
//		pointsb [4] = 50;

//		for (int ib = 4; ib >= 0; ib--)
//		{
//			Debug.Log (pointsb [ib]);
//		}
	}


	// Update is called once per frame
	void Update () {
	}

	}
