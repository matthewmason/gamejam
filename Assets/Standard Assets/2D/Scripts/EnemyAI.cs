using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	public Transform target;
	public float moveSpeed;
	public int rotationSpeed;

	private Transform myTransform;

	// Use this for initialization
	void Awake() {
		myTransform = transform;
	}

	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag("Player");

		target = go.transform;
	}

	// Update is called once per frame
	void Update () {    
		Vector3 dir = target.position - myTransform.position;
		dir.z = 0.0f; // Only needed if objects don't share 'z' value
		if (dir != Vector3.zero) {
			myTransform.rotation = Quaternion.Slerp (myTransform.rotation, 
				Quaternion.FromToRotation(Vector3.right, dir), rotationSpeed * Time.deltaTime);
		}

		//Move Towards Target
		myTransform.position += (target.position - myTransform.position).normalized * moveSpeed * Time.deltaTime;

	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "Ground" )
		{
			
		}
	}
}