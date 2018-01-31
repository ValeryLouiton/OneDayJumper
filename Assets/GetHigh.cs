using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHigh : MonoBehaviour
{
    public Text highText;
    private static int highScore;

    public static int GetHighScore
    {
        get { return highScore; }
        set { highScore = value; }
    }

    void Start ()
    {
        highScore = PlayerPrefs.GetInt("Highscore", ScoreManager.ScoreAccess);
        highText.text = "Highscore : " + highScore;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
