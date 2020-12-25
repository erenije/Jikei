using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D coll)
	{
		coll.transform.parent = transform;
	}

	void OnCollisionExit2D(Collision2D coll)
	{
		coll.transform.parent = null;
	}
}
