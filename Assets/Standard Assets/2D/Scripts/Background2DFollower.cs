using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background2DFollower : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start () {
//		transform.parent = null;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPos = target.position;
		newPos.y = 7.8f;
		transform.position = newPos;
	}
}
