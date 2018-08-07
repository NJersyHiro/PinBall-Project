using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AddScore : MonoBehaviour {


	//スコアを表示するテキスト
	private Text ScoreText;
	//スコア変数
	public int defscore = 0;


	// Use this for initialization
	void Start () {

		if (tag == "SmallStarTag") {
			this.defscore = 10;
		} else if (tag == "LargeStarTag") {
			this.defscore = 50;
		}else if(tag == "SmallCloudTag"){
			this.defscore = 70;

		}else if (tag == "LargeCloudTag") {
			this.defscore = 100;
		}
	}



	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision other){

		ScoreText.text = "Score; " + defscore;				
			
	}


}