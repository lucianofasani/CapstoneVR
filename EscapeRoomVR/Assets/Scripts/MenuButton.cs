using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {

    public enum ButtonMode {START, TUTORIAL, EXIT};

    public ButtonMode currentMode;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

    void Action()
    {
        switch(currentMode)
        {
            case ButtonMode.START:
                Debug.Log("START THE GAME");
                SceneManager.LoadScene("lfasani3", LoadSceneMode.Single);
                break;
            case ButtonMode.TUTORIAL:
                Debug.Log("START THE TUTORIAL");
                SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
                break;
            case ButtonMode.EXIT:
                Debug.Log("EXIT THE GAME");
                Application.Quit();
                break;
            default:
                break;
        }
    }
}
