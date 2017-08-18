using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    // Loading screen bar
    [SerializeField]
    Slider loadingScreenBar;

    // Menu UI container
    [SerializeField]
    GameObject menuUI;

    // Loading Screen UI container
    [SerializeField]
    GameObject loadingScreenUI;

    // Option Menu UI Container
    [SerializeField]
    GameObject optionScreenUI;

    // Quality Dropdown Menu
    [SerializeField]
    Dropdown qualityDropdownMenu;
    // Quality Dropdown Text
    [SerializeField]
    Text qualityDropdownText;

    // Menu UI container
    [SerializeField]
    MusicManager musicManager;
    // Music Volume Bar
    [SerializeField]
    Slider musicVolumeBar;
    // Music Volume Value Text
    [SerializeField]
    Text musicVolumeText;

    // The max progression value of a slider
    const float unityProgressCap = 0.9f;

    // bool tracking if user is in options
    bool isInOptions;

	// Use this for initialization
	void OnEnable() {
        isInOptions = false;

        // Gets saved graphics quality; set quality to low if key not found
        QualitySettings.masterTextureLimit = PlayerPrefs.GetInt("graphicsQuality", 2);
        qualityDropdownMenu.value = QualitySettings.masterTextureLimit;
        qualityDropdownText.text = getTextureName(QualitySettings.masterTextureLimit);

        // Music Volume
        musicManager.setVolume(PlayerPrefs.GetFloat("musicVolume", 0.5f));
        musicVolumeBar.value = musicManager.getVolume();
        musicVolumeText.text = "" + (int)(musicManager.getVolume() * 100f);

    }

	// Opens options UI and closed main menu UI
    public void toggleOptionsUI()
    {
        // Disables/Enables menu
        menuUI.SetActive(isInOptions);

        // Inverts option bool and Enables/Disables options
        optionScreenUI.SetActive(isInOptions = !isInOptions);
    }

    // Changes the music volume and saves the value to local files
    public void changeMusicVol()
    {
        // Convert percentage to whole number
        musicManager.setVolume(musicVolumeBar.value);
        musicVolumeText.text = "" + (int)( musicVolumeBar.value * 100f);
        PlayerPrefs.SetFloat("musicVolume", musicVolumeBar.value);
    }

    // Changes the quality and saves the value to local files
    public void changeQuality()
    {
        QualitySettings.masterTextureLimit = qualityDropdownMenu.value;
        qualityDropdownText.text = getTextureName(QualitySettings.masterTextureLimit);
        PlayerPrefs.SetInt("graphicsQuality", QualitySettings.masterTextureLimit);
    }

    // Loads a level async
    public void loadLevel(string _name)
    {
        // Loads screen async
        StartCoroutine(loadAsync(_name));
    }

    // Async load game scene to allow UI to display progression of setting up the scene
    IEnumerator loadAsync(string _levelName)
    {
        menuUI.SetActive(false);

        // Loads next scene asynchronously
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(_levelName);

        loadingScreenUI.SetActive(true);

        // Until loading process is complete
        while (!asyncLoad.isDone)
        {
            // Update the progression bar UI
            float progress = Mathf.Clamp01(asyncLoad.progress / unityProgressCap);
            loadingScreenBar.value = progress;

            yield return null;
        }
    }

    // Gets the current index in the dropdown menu and gets the name
    // 0: High, 1: Medium, 2: Low
    private string getTextureName(int _textureQuality)
    {
        switch (_textureQuality)
        {
            case 0:
                return "High";
            case 1:
                return "Medium";
            default:
                return "Low";
        }
    }
}
