using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

    public GameObject[] obstacles;
    int obstacleNo;
    private float maxPos = 21f; // 21 is the starting position of the obstacle spawning from the track
    public float delayTimer;
    float timer;

	// Use this for initialization
	void Start () {
        timer = delayTimer;
		
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 obstaclePos = new Vector3(maxPos, transform.position.y, transform.position.z);
            obstacleNo = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[obstacleNo], obstaclePos, transform.rotation);
            if (delayTimer > 0.6f)
            {
                delayTimer -= 0.15f;
            }
            timer = delayTimer;
        }
	}
}
