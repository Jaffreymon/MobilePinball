using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

    [SerializeField]
    private List<AudioClip> songList;

    [SerializeField]
    private AudioSource musicPlayer;

    private static MusicManager instance = null;
    
    // Singleton assuring only one instance of a music manager exists
    public static MusicManager Instance
    {
        get { return instance; }
    }

    public void setVolume(float _volume)
    {
        musicPlayer.volume = _volume;
    }

    public float getVolume()
    {
        return musicPlayer.volume;
    }

    public MusicManager getMusicManager()
    {
        return instance;
    }

    void Awake()
    {
        // Saves the first instance of music manager
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        } else {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

}
