using UnityEngine;
using System.Collections;

public class Lesson2Score : MonoBehaviour {

	private int nowScore = 0;
	
	// Update is called once per frame
	void Update () {
		this.guiText.text =  " SCORE:" + nowScore;
	}

	public void UpdateScore(int getScore){
		nowScore += getScore;
	}
}
