using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public List<OffscreenCheck> floor = new List<OffscreenCheck>(15);
	private Queue<OffscreenCheck> floorTiles = new Queue<OffscreenCheck>();
	private Queue<OffscreenCheck> secondplayerqueue = new Queue<OffscreenCheck>();
	public Camera cam;
	public OffscreenCheck blank;
	public Vector3 lastQueued;
	public float tileSize;
	// Use this for initialization
	void Start () {
		foreach(OffscreenCheck i in floor)
		{
			if(i!=null)
			{
			floorTiles.Enqueue(i);
			lastQueued = new Vector3(i.transform.position.x,i.transform.position.y,i.transform.position.z);
			}
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
				print("im run");
				temp = secondplayerqueue.Dequeue();
				temp.transform.position = new Vector3(lastQueued.x + tileSize,.5f , lastQueued.z);
				floorTiles.Enqueue(temp);
				temp.enabled = true;
			}
			else
			{
				temp = Instantiate(blank, new Vector3(lastQueued.x + tileSize,.5f,lastQueued.z), Quaternion.identity);
				floorTiles.Enqueue(temp);
			}
			lastQueued = new Vector3(temp.transform.position.x, temp.transform.position.y, temp.transform.position.z );
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
	public void addToQueue(GameObject G)
	{
		OffscreenCheck g = G.GetComponent<OffscreenCheck>();
		secondplayerqueue.Enqueue(g);
	}
}
