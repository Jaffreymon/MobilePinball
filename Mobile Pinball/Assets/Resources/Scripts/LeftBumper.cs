using System.Collections.Generic;
using UnityEngine;

public class LeftBumper : MonoBehaviour
{

    // List of sounds when ball collides with this bumper
    List<AudioClip> hitSFX;

    // Gameobject of bumper's hinge
    [SerializeField]
    private HingeJoint bumper;

    [SerializeField]
    private JointMotor bumperMotor;

    // Target force of bumper
    float appliedTargetVelocity = 750f;

    void Start()
    {
        bumper = GetComponent<HingeJoint>();
        bumperMotor = bumper.motor;
    }


    public void toggleBumper()
    {
        // Negates targetVelocity
        appliedTargetVelocity = -appliedTargetVelocity;
        // Applies targetVelocity
        bumperMotor.targetVelocity = appliedTargetVelocity;

        // Reassign motor to hinge joint
        bumper.motor = bumperMotor;
    }
}
