using UnityEngine;

public class BallBehavior : MonoBehaviour {

    // Set position to a specified spawn point
    public void setBallPos(Transform _ballSpawn)
    {
        gameObject.SetActive(false);

        GetComponent<Rigidbody>().velocity = Vector3.zero;
        transform.position = _ballSpawn.position;

        gameObject.SetActive(true);
    }

    // Adds force to the ball given it's in the specified area
    public void addForce(float _force, Vector3 _direction)
    {
        // Applies a force to this ball with a velocity of given transform
        GetComponent<Rigidbody>().AddForce(_force * _direction, ForceMode.Impulse);
    }
}
