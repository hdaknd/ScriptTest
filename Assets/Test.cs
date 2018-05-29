using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
        private int hp = 100;          // 体力
        private int power = 25; // 攻撃力
	private int mp = 53; // MP

        // 攻撃用の関数
        public void Attack() { 
                Debug.Log( this.power + "のダメージを与えた" );
        }

        // 防御用の関数
        public  void Defence(int damage) { 
                Debug.Log( damage+"のダメージを受けた" );
                // 残りhpを減らす
                this.hp -= damage;
        }

	// 魔法用の関数
	public  void Magic(){ 
		// 残りmpを減らす
                this.mp -= 5;
		if ( this.mp > 0) {
                	Debug.Log( "魔法攻撃をした。残りMPは"+ this.mp +  "。" );
		} else {
			Debug.Log( "MPが足りないため魔法が使えない。");
		}
        }
}


public class Test : MonoBehaviour {
	// Use this for initialization
	void Start () {
		//要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
		int[] ary = new int[5];
		ary [0] = 1;
		ary [1] = 4;
		ary [2] = 9;
		ary [3] = 16;
		ary [4] = 25;

		//配列の各要素の値を順番に表示してください
		for (int i = 0; i < 5; i++) {
			Debug.Log (ary [i]);
		}
			
		//for文を使い、配列の各要素の値を逆順に表示してください
		for (int i = 5; i > 0 ; i--) {
			Debug.Log (ary [i - 1]);
		}


               // Bossクラスの変数を宣言してインスタンスを代入
                Boss lastboss = new Boss ();

                // 攻撃用の関数を呼び出す
                lastboss.Attack();
                // 防御用の関数を呼び出す
                lastboss.Defence(3);
		// 魔法用の関数を呼び出す
		for (int i = 1; i <= 11; i++ ) {
			Debug.Log( i + "回目の魔法。");
			lastboss.Magic();
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
