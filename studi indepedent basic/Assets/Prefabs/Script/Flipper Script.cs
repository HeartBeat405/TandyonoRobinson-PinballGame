using UnityEngine;

public class FlipperController : MonoBehaviour
{
    public float maxAngle = 45f; // Sudut maksimal putaran flipper
    public float flipperForce = 1000f; // Kekuatan yang diterapkan pada flipper

    private HingeJoint hingeJoint;
    private JointSpring initialSpring;

    private void Start()
    {
        hingeJoint = GetComponent<HingeJoint>();
        initialSpring = hingeJoint.spring;
    }

    private void Update()
    {
        // Mengontrol flipper menggunakan tombol tertentu (misalnya: 'A' dan 'D' pada keyboard)
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            ApplyFlipperForce(maxAngle);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            ApplyFlipperForce(-maxAngle);
        }
        else
        {
            ResetFlipper();
        }
    }

    private void ApplyFlipperForce(float targetAngle)
    {
        JointSpring spring = hingeJoint.spring;
        spring.targetPosition = targetAngle;
        hingeJoint.spring = spring;

        hingeJoint.useSpring = true;
        hingeJoint.useMotor = false;
    }

    private void ResetFlipper()
    {
        hingeJoint.spring = initialSpring;
        hingeJoint.useSpring = true;
        hingeJoint.useMotor = true;
    }
}
