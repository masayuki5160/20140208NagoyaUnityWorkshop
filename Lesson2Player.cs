using UnityEngine;
using System.Collections;

public class Lesson2Player : MonoBehaviour {

	public float speed;
	
	void Update () {
		// キー入力がされたときの処理
		if(Input.GetAxisRaw("Horizontal") != 0){
			rigidbody2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, 0);
		}
	}
}
