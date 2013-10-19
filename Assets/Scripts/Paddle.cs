using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	
	public static Paddle Instance;
	
	public float paddleSpeed = 5f;
	
	void Awake()
	{
		Instance = this;
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey(KeyCode.A)) {
			if (transform.position.x > -5f)
			transform.Translate(-paddleSpeed * Time.deltaTime, 0f, 0f);
		} else if (Input.GetKey(KeyCode.D)) {
			if (transform.position.x < 5f)
			transform.Translate(paddleSpeed * Time.deltaTime, 0f, 0f);
		}
	}
	
	void OnCollisionEnter()
	{
		Loser.Instance.AddBall();
	}
}
