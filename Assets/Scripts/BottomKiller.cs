using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomKiller : MonoBehaviour
{
    public GameObject player;
    public GameObject gameOver;
    private BoxCollider2D bottomKiller;

	void Start ()
    {
        bottomKiller = GetComponent<BoxCollider2D>();
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Game over !");
        player.SetActive(false);
        Instantiate(gameOver);
    }

    void Update ()
    {
		if (transform.position.y < player.transform.position.y - 7f)
        {
            transform.position = new Vector3(0f, player.transform.position.y - 7f, 0f);
        }
	}
}
