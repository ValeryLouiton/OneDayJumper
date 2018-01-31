using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    private float offset;
    public GameObject player;

	void Start ()
    {
        offset = transform.position.y - player.transform.position.y;
	}

    private void LateUpdate()
    {
        if (transform.position.y < player.transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
        }
    }
}
