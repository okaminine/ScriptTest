using UnityEngine;
using System.Collections;

public class Boss{   
	
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	private int mp = 53; //魔力
	private int magic = 5; //魔法消費



	// 攻撃用の関数
	public void Attack(){ 
		Debug.Log( this.power + "のダメージを与えた" );
	}



	// 防御用の関数
	public  void Defence(int damage){ 
		Debug.Log (damage + "のダメージを受けた");
		// 残りhpを減らす
		this.hp -= damage;
	}


	//魔法攻撃用の関数
		public void Magic(){

		if (this.mp >= magic) {
			this.mp -= magic;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp);
		}

		if (this.mp < magic){
			Debug.Log ("MPが足りないので魔法攻撃できない。");
		}

		//if (this.mp <= magic)
			// (53-magic×回数)がmagic5より少なくなったときtrue
		//	Debug.Log ("MPが足りないので魔法攻撃できない。");
		//else {
		//	this.mp -= magic;	
			// mp = mp-magic
		//	Debug.Log ("魔法攻撃をした。残りMPは" + mp);

		//	if (this.mp <= magic)
				//mpがmagicより少ないときtrue
		//		Debug.Log ("MPが足りないので魔法攻撃できない。");
		}


	}

		
		

public class BossTest : MonoBehaviour {

	void Start () {
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 攻撃用の関数を呼び出す
		lastboss.Attack ();
		// 防御用の関数を呼び出す
		lastboss.Defence (3);
		//Magicの関数を呼び出す

		//Magic関数を10回使う
		for (int i = 0; i < 10; i++) {
			lastboss.Magic ();


		}

//		for (int i = 53; i >= 5; i -= 5){
//			Debug.Log (i);
//		}	
	}
	
	void Update(){
	}	
}
