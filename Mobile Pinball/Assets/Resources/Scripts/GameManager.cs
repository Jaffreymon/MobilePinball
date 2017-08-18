using UnityEngine;

public class GameManager : MonoBehaviour {

    // The current score of this session
    int currScore;
    // The high score saved on this device
    int highScore;
    // The total remaining lives
    int ballsRemaining;

    // Reference to game's menu
    GameMenu pauseMenu;
    // Reference to ball
    GameObject ball;

    // Detects if the game is paused
    bool isGamePaused = false;


	// Use this for initialization
	void Start () {
        highScore = PlayerPrefs.GetInt("playerHighScore", 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // returns if game is paused
    bool isPause() { return isGamePaused; }

    // Inverts the current state of the game 
    void Pause()
    {
        // Inverts the current game state and UI if paused 
    }

    // Gets current score of session
    int getCurrScore() { return currScore; }

    // Gets highest score on device
    int getHighScore() { return highScore; }

    // Gets remaining lives
    int getBallsRemaining() { return ballsRemaining; }

    // Sets the ball count
    void setBallCount(int _ballCount) { ballsRemaining = _ballCount; }

    // Sets the current score
    void setScore(int _score) { currScore = _score; }

    // Sets the position of the ball
    void setBallPosition(Vector3 _pos)
    {
        // TODO Set ball's transform to given vector3
    }
}
