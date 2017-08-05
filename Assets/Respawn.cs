using UnityEngine;
using System.Collections;
 
public class Respawn : MonoBehaviour {

	public float threshold = -30f;
	public GameObject player;

	void Update () {

		if (player.transform.position.y < threshold) {
			player.transform.position = new Vector3 (-6.39f, 0f, 0f);
		}
	}
 }