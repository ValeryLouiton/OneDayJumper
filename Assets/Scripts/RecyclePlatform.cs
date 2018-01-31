using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecyclePlatform : MonoBehaviour
{
    public Camera gameCamera;
    public GameObject platform;
    private Transform platformPosition;

	void Start ()
    {
        platformPosition = GetComponent<Transform>();
	}
	
	void Update ()
    {
		if (transform.position.y < gameCamera.transform.position.y - 20f)
        {
            platformPosition.position = new Vector3((Random.value * 16f) - 8f, 0f, 0f);
        }
	}
}
