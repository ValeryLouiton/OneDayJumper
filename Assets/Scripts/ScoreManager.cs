using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject player;
    public Text scoreText;
    private int score;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        if (score < player.transform.position.y)
        {
            score = Mathf.FloorToInt(player.transform.position.y);
        }
    }

    private void LateUpdate()
    {
        scoreText.text = "Score : " + score.ToString();
    }
}
