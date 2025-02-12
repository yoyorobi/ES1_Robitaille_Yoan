using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevierCatapulte : MonoBehaviour
{

public HingeJoint hinge;
    private bool isDown = false;

    void Start()
    {
        JointMotor motor = hinge.motor;
        motor.force = 0; 
        motor.targetVelocity = 0;
        hinge.motor = motor;
        hinge.useMotor = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bille") && !isDown) 
        {
            JointMotor motor = hinge.motor;
            motor.force = 250; 
            motor.targetVelocity = -30; 
            hinge.motor = motor;
            hinge.useMotor = true;
            isDown = true; 

            Invoke("RemonterLevier", 1f);
        }
    }

    void RemonterLevier()
    {
        
            JointMotor motor = hinge.motor;
            motor.targetVelocity = 250; 
            hinge.motor = motor;
            hinge.useMotor = true;
            isDown = false;
            
        
        hinge.useLimits = true;

    }
}

