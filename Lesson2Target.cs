using UnityEngine;
using System.Collections;

public class Lesson2Target : MonoBehaviour {

	public string TagetObjectName;
	private int Point = 10;
	private GameObject GameManager;
	private string TargetTag = "Player";

	void Start(){
		GameManager =  GameObject.Find(TagetObjectName);
	}

	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag == TargetTag){
			Destroy(gameObject);
			GameManager.SendMessage ("GetScore",  10);
		}
	}
}
