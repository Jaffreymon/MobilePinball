using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPit : MonoBehaviour {

    // Reference to pinball
    [SerializeField]
    GameManager gameManager;

    // Spring UI only shows when ball is in start position
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            gameManager.resetLevel();
        }
    }

}
