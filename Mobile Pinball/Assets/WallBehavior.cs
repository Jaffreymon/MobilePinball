using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Ball" )
        {
            toggleWallCollision(true);
        }
    }

    /// <summary>
    /// Method will toggle this wall's visibility and collision detection
    /// </summary>
    /// <param name="_wallTrigger"> Value of true will make this wall visible and collide; Counterpart of value false </param>
    public void toggleWallCollision(bool _wallTrigger)
    {
        GetComponent<MeshRenderer>().enabled = _wallTrigger;
        GetComponent<MeshCollider>().isTrigger = !_wallTrigger;
    }
}
