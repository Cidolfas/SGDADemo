using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		Loser.Instance.brickList.Add(this);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	void OnCollisionEnter ()
	{
		Loser.Instance.brickList.Remove(this);
		Destroy(gameObject);
	}
}
