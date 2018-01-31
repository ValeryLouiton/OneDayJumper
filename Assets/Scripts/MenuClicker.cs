using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuClicker : MonoBehaviour {

    public Button startButton;

	void Start ()
    {
        startButton = GetComponent<Button>();
        startButton.onClick.AddListener(StartGame);
	}

    void StartGame()
    {
        SceneManager.LoadScene("MainInGame");
    }
}
