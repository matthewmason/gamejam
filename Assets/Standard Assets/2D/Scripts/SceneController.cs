using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneController : MonoBehaviour {

	public Text countText;
	public Transform player;

	private int count;

	private void Awake()
	{
		count = 0;
		SetCountText();
	}

	private void Update()
	{
		int newPos = (int)6.39 + (int)player.position.x;

		if (count <= newPos) {
			count = newPos;
		}
			
		SetCountText();
	}

	private void SetCountText ()
	{
		countText.text = "Score: " + count.ToString ();
	}
}