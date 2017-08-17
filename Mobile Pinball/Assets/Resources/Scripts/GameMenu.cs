using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameMenu : MonoBehaviour {
    
    // All UI gameobjects go here


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Loads current scene to mainMenu
    void Quit()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
