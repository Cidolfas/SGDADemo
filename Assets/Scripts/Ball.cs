using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	public float power;
	
	public Vector3 vel;
	
	// Use this for initialization
	void Start ()
	{
		float pm = (Random.value > 0.5f) ? -1f : 1f;
		float x = Random.Range(power / 2f, power) * pm;
		float y = Random.Range(power / 2f, power);
		Vector3 v = new Vector3(x, y, 0f);
		vel = v;
		rigidbody.AddForce(v);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	void OnCollisionEnter(Collision col)
	{
		print("We're hit!");
		Vector3 n = col.contacts[0].normal;
		print(n);
		
		vel = Vector3.Reflect(vel, n);
		
		rigidbody.AddForce(vel);
	}
}
