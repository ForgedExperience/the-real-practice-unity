using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomGeneration : MonoBehaviour {

	public List<int> Ynum = new List<int>();
	public List<int> Xnum = new List<int>();
	private int myNumberX;
	private int myNumberY;
	public int minX;
	public int maxX;
	public int minY;
	public int maxY;
	public int limit;
	private int timeAmount;
	private int timer;
	private Vector3 spawnPoint;
	public GameObject Obstacle;

	void Start()
	{
		timer = 0;
	}
	void Update()
	{
		if (timer != 100) {
			myNumberX = Random.Range (minX, maxX);
			myNumberY = Random.Range (minY, maxY);
			timer = timer + 1;
		}

		if (!Xnum.Contains (myNumberX) || !Ynum.Contains (myNumberY) && timeAmount > limit) {
			if(!Xnum.Contains(myNumberX)){
				Xnum.Add (myNumberX);
			}
			if(!Ynum.Contains(myNumberY)){
				Xnum.Add (myNumberX);
			}
			spawnPoint = new Vector3 (myNumberX, transform.position.y,  myNumberY);
			Ynum.Add (myNumberY);
			Instantiate (Obstacle, spawnPoint,transform.rotation);
		}
	}
}
