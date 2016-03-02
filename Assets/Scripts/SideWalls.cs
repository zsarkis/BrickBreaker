using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision)
	{
		print ("Collision");
	}
}
