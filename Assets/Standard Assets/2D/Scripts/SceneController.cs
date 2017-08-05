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

	public void setCount(int newPos)
	{
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