using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float MoveSpeed;
    public float JumpSpeed;
    public float Friction;
    public float MaxSpeed;
    public bool Grounded;

    private void Update()
    {
        if (Grounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Rigidbody.AddForce(0, JumpSpeed, 0, ForceMode.VelocityChange);
            }

        }
    }

    private void FixedUpdate()
    {
        float speedMultiplier = 1f;

        if (Grounded == false)
        {
            speedMultiplier = 0.2f;
        }

        if (Rigidbody.velocity.x > MaxSpeed && Input.GetAxis("Horizontal") > 0)
        {
            speedMultiplier = 0;
        }

        if (Rigidbody.velocity.x < -MaxSpeed && Input.GetAxis("Horizontal") < 0)
        {
            speedMultiplier = 0;
        }

        Rigidbody.AddForce(Input.GetAxis("Horizontal") * MoveSpeed * speedMultiplier, 0, 0, ForceMode.Acceleration);

        if (Grounded)
        {
            Rigidbody.AddForce(-Rigidbody.velocity.x * Friction, 0, 0, ForceMode.Acceleration);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {

    }
    private void OnCollisionStay(Collision collision)
    {
        float angle = Vector3.Angle(collision.contacts[0].normal, Vector3.up);
        if (angle < 45)
        {

            Grounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Grounded = false;
    }


}
