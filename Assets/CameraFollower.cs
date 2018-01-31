using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    private Vector3 offset;
    public GameObject player;

	void Start ()
    {
        offset = transform.position - player.transform.position;
	}

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
