using UnityEngine;
using System.Collections.Generic;

public class Loser : MonoBehaviour {
	
	public static Loser Instance;
	
	public int mans = 3;
	
	public GameObject ballPrefab;
	public List<GameObject> oldBalls = new List<GameObject>();
	
	public List<Brick> brickList = new List<Brick>();
	
	void Awake()
	{
		Instance = this;
	}
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		if (brickList.Count == 0) {
			print("You win!");
			foreach(GameObject ball in oldBalls) {
				RemoveBall(ball);
			}
		}
	}
	
	void OnCollisionEnter(Collision col)
	{
		print("Oh No!");
		RemoveBall(col.gameObject);
		if (oldBalls.Count < 1) {
			mans--;
			if (mans < 0) {
				print("Game Over!");
			} else {
				AddBall();
			}
		}
	}
	
	public void AddBall()
	{
		oldBalls.Add((GameObject)Instantiate(ballPrefab, Paddle.Instance.transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity));
	}
	
	public void RemoveBall(GameObject ball)
	{
		Destroy(ball);
		oldBalls.Remove(ball);
	}
}
