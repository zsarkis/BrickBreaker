using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public Paddle paddle;
	private bool hasStarted;
	private Vector3 paddleToBallVector;
	// Use this for initialization
	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (hasStarted == false) 
		{
			this.transform.position = paddle.transform.position + paddleToBallVector;
			if (Input.GetMouseButtonDown (0)) 
			{
				print("Mouse Clicked");
				this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f,10f);
				hasStarted = true;
			}
		}

	}
}
