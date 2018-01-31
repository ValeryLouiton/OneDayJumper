using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRigidbody;
    public float forceUp = 10f;
    public float sideForce = 5f;
    private float moveX;

	void Start ()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        GetInput();
        MoveSide(moveX);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Touchy !");
        playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, 0f);
        playerRigidbody.AddForce(Vector2.up * forceUp, ForceMode2D.Impulse);
    }

    private void GetInput()
    {
        moveX = Input.GetAxis("Horizontal");
        moveX *= sideForce;
    }

    private void MoveSide(float moveX)
    {
        Vector2 moveVector = playerRigidbody.velocity;
        moveVector.x = moveX;
        playerRigidbody.velocity = moveVector;
    }
}
