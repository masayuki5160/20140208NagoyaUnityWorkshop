using UnityEngine;
using System.Collections;

public class Lesson2Target : MonoBehaviour {
	// SendMessageの送り先になるObject名
	public string TagetObjectName;

	private int Point = 10;
	private GameObject GameManager;
	// 操作キャラに付与されているタグ名
	private string Tag = "Player";

	void Start(){
		GameManager =  GameObject.Find(TagetObjectName);
	}

	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag == Tag){
			// 衝突したのがTag(プレイヤー)だったら得点獲得＆自身はきえる
			Destroy(gameObject);
			GameManager.SendMessage ("GetScore",  10);
		}
	}
}
