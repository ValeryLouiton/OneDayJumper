using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject player;
    public Text scoreText;
    private static int score;

    public static int ScoreAccess
    {
        get { return score; }
        set
        {
            if(value > 0)
            {
                score = value;
            }
        }
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
