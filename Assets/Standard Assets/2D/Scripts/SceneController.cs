﻿using UnityEngine;
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
		string paranoiaValue = ((paranoia - 1) / 5 * 100).ToString("F0");
		countText.text = "Score: " + count.ToString () + ", Paranoia: " + paranoiaValue + "%";
	}

	public void incrementParanoia(float amt)
	{
		if (paranoia < 6f) {
			paranoia += amt;
			print (paranoia);
		}

		if (paranoia >= 6f) {
			print ("Respawning");
			respawn ();
		}
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