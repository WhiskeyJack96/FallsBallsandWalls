using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public List<OffscreenCheck> floor = new List<OffscreenCheck>(15);
	private Queue<OffscreenCheck> floorTiles = new Queue<OffscreenCheck>(15);
	private Queue<OffscreenCheck> secondplayerqueue = new Queue<OffscreenCheck>();
	public Camera cam;
	public OffscreenCheck blank;
	public OffscreenCheck lastQueued;
	public float tileSize;
	// Use this for initialization
	void Start () {
		foreach(OffscreenCheck i in floor)
		{
			floorTiles.Enqueue(i);
		}
	}
	
	// Update is called once per frame
	void Update () {
		int dqNum = checkOffScreen();
		for(int i=0;i<dqNum;i++)
		{
			OffscreenCheck oldTile = floorTiles.Dequeue();
			Destroy(oldTile.gameObject);
			OffscreenCheck temp;
			if(secondplayerqueue.Count>0)
			{
				temp = secondplayerqueue.Dequeue();
				floorTiles.Enqueue(temp);
			}
			else
			{
				temp = Instantiate(blank, new Vector3(lastQueued.transform.position.x + tileSize,lastQueued.transform.position.y,lastQueued.transform.position.z), Quaternion.identity);
				floorTiles.Enqueue(temp);
			}
			lastQueued = temp;
		}
		
	}

	int checkOffScreen()
	{
		int temp = 0;
		foreach(OffscreenCheck i in floorTiles)
		{
			if(i!= null && !i.CheckInBounds())
			{
				temp++;
			}
		}
		return temp;
	}

	void queueMove(OffscreenCheck G)
	{
		secondplayerqueue.Enqueue(G);
	}
}
