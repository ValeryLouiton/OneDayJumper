using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public float distanceBetweenPlatforms = 4f;
    public float platformHeight = 4f;
    public float playerHeight;
    public float increaseDistance = 0.1f;
    public GameObject platform;
    public GameObject player;

    void Start ()
    {
		for (int i = 0; i < 20; i++)
        {
            GeneratePlatform();
        }
	}
	
	void Update ()
    {
		if (platformHeight - player.transform.position.y <= 15f || player.transform.position.y > 150f)
        {
            GeneratePlatform();
            if (distanceBetweenPlatforms < 12f)
            {
                distanceBetweenPlatforms += increaseDistance;
            }
        }
    }

    void GeneratePlatform()
    {
        Instantiate(platform, new Vector3(((float)Random.value * 16f) - 8f, platformHeight, 0f), Quaternion.identity);
        platformHeight += distanceBetweenPlatforms;
    }
}
