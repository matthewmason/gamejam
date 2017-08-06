using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneController : MonoBehaviour {

	public Text countText;
	public float paranoia;
	public Transform player;
	public float threshold = -30f;

	private int count;

	private void Awake()
	{
		count = 0;
		paranoia = 1f;
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
		countText.text = "Score: " + count.ToString () + "\nParanoia multiplier :" + paranoia.ToString();
	}

	public void incrementParanoia(float amt)
	{
		paranoia += amt;
	}

	public void decrementParanoia(float amt)
	{
		if (paranoia > 1f) {
			paranoia -= amt;
		}
	}

	public float getParanoia()
	{
		return paranoia;
	}

	public void resetParanoia()
	{
		paranoia = 1f;
	}

	public void resetCount()
	{
		count = 0;
	}

	public void respawn()
	{
		player.transform.position = new Vector3 (-6.39f, 0f, 0f);

		resetParanoia ();
		resetCount ();
	}

	public float getThreshold() 
	{
		return threshold;
	}

	public Transform getPlayer() {
		return player;
	}
}