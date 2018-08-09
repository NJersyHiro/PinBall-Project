using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	//ボールが見える可能性のあるz軸の最大値
	private float score = 0f;
	float smallstarscore = 10f;
	float largestarscore = 30f;
	float largecloudscore = 60f;


	//Scoreを表示するテキスト
	private GameObject scoreText;

	// Use this for initialization
	void Start () {
		//シーン中のScoreTextオブジェクトを取得
		this.scoreText = GameObject.Find("ScoreText");


	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag ("LargeCloudTag")) {

			score += largecloudscore;
		} else if (col.gameObject.CompareTag ("LargeStarTag")) {

			score += largestarscore;
		} 


		Debug.Log (score);
		//AddScore2に点数を表示
		this.scoreText.GetComponent<Text> ().text = score.ToString();
	}


}