using UnityEngine;
using System.Collections;

public class Lesson2GameManager : MonoBehaviour {

	public GameObject targetPrefab;
	private GameObject ScoreObj;
	private float DropPosY = 8.0f;
	
	void Start () {
		ScoreObj = GameObject.Find("Score");
	}
	
	void Update () {
		if(Time.frameCount % 100 == 0){
			float tmpXpos = Random.Range(-8.0f, 8.0f);
			Instantiate(targetPrefab,new Vector2(tmpXpos, DropPosY), Quaternion.identity);
		}
	}

	void GetScore(int GetPoint){
		ScoreObj.SendMessage("UpdateScore",GetPoint);
	}
}
