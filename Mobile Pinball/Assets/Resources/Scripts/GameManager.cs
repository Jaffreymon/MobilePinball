﻿using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // The current score of this session
    int currScore;
    // The high score saved on this device
    int highScore;
    // The total remaining lives
    int ballsRemaining;

    // Reference to game's menu
    [SerializeField]
    GameMenu pauseMenu;

    // Reference to ball
    [SerializeField]
    BallBehavior ball;

    // Reference to parent of hidden walls
    [SerializeField]
    GameObject safetyWallsHolder;

    // Player spring control UI 
    [SerializeField]
    startPositionHitBox mainBallStart;

    // UI Spring to hit ball
    [SerializeField]
    Slider springUI;

    // Reference to ball spawn positions
    [SerializeField]
    Transform[] ballSpawns;
    // ball spawn indices
    const int startPosIdx = 0;

    // Detects if the game is paused
    bool isGamePaused = false;


	// Use this for initialization
	void Start () {
        highScore = PlayerPrefs.GetInt("playerHighScore", 0);
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallBehavior>();
	}

    // returns if game is paused
    bool isPause() { return isGamePaused; }
    // Inverts the current state of the game 
    void Pause()
    {
        // Inverts the current game state and UI if paused 
    }

    // Gets the springUI
    public Slider getSpringUI() { return springUI; }
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
    // Sets the position of the ball to one of specified spawn points
    void setBallPosition(int _idx)
    {
        ball.setBallPos(ballSpawns[_idx]);
    }

    // Resets the ball position and hidden walls
    public void resetLevel()
    {
        springUI.value = 0f;
        setBallPosition(startPosIdx);

        foreach(WallBehavior child in safetyWallsHolder.GetComponentsInChildren<WallBehavior>())
        {
            child.toggleWallCollision(false);
        }
    }

    // Applies a force to the pinball given by the user
    public void springUpBall()
    {
        ball.addForce(mainBallStart.getSliderVal(), ballSpawns[startPosIdx].forward);
    }

    public void toggleSpringUI(bool _isActive)
    {
        springUI.gameObject.SetActive(_isActive);
    }
}
