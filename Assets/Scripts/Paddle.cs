using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float mousePosInBlocks = Mathf.Clamp((Input.mousePosition.x / Screen.width * 16), 0.5F, 15.5F);
//		print(Input.mousePosition.x / Screen.width * 16);
//		print(mousePosInBlocks);
//		transform.position = new Vector3(Mathf.Clamp(Time.time, 1.0F, 3.0F), 0, 0);
		Vector3 paddlePos =  new Vector3(mousePosInBlocks,this.transform.position.y,this.transform.position.z);
		this.transform.position = paddlePos;
	}
}
