using UnityEngine;
using System.Collections;

public class Lesson2GameManager : MonoBehaviour {

	public GameObject targetPrefab;
	private Lesson2Score ScoreScript;
	private float DropPosY = 8.0f;
	
	void Start () {
		ScoreScript = GameObject.Find("GetScore").GetComponent<Lesson2Score>();
	}
	
	void Update () {
		if(Time.frameCount % 100 == 0){
			float tmpXpos = Random.Range(-8.0f, 8.0f);
			Instantiate(targetPrefab,new Vector2(tmpXpos, DropPosY), Quaternion.identity);
		}
	}

	void GetScore(int GetPoint){
		ScoreScript.UpdateScore(GetPoint);
	}
}
