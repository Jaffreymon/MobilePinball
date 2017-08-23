using UnityEngine.UI;
using UnityEngine;
public class startPositionHitBox : MonoBehaviour {

    // Reference to pinball
    [SerializeField]
    GameManager gameManager;

    Slider springUI;

    private void Start()
    {
        springUI = gameManager.getSpringUI();
    }

    public float getSliderVal()
    {
        return springUI.value;
    }

    // Spring UI only shows when ball is in start position
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Ball")
        {
            gameManager.toggleSpringUI(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball")
        {
            gameManager.toggleSpringUI(false);
        }
    }
}
