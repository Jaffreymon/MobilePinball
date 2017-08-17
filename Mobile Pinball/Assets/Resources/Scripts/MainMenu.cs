using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void loadLevel(string _name)
    {
        // Loads screen async
        
    }

    // Async load game scene to allow UI to display progression of setting up the scene
    IEnumerator loadAsync(string _levelName)
    {
        /* TODO     disable mainMenu UI and show loading screen
         
        loadoutMenu.SetActive(false);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(_levelName);

        loadingScreen.SetActive(true);

        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / unityProgressCap);
            loadingScreenBar.value = progress;

            yield return null;
        }
        */
        yield return null;
    }
}
