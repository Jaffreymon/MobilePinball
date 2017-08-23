using System.Collections.Generic;
using UnityEngine;

public class RightBumper : MonoBehaviour {

    // List of sounds when ball collides with this bumper
    List<AudioClip> hitSFX;

    // Gameobject of bumper's hinge
    [SerializeField]
    private HingeJoint bumper;

    [SerializeField]
    private JointMotor bumperMotor;

    // Target force of bumper
    float appliedTargetVelocity;

    void Start()
    {
        bumper = GetComponent<HingeJoint>();
        appliedTargetVelocity = bumper.motor.targetVelocity;
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
