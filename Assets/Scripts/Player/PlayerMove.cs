using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float MoveSpeed;
    public float JumpSpeed;
    public float Friction;
    public float MaxSpeed;
    public bool Grounded;
    public Transform ColliderTransform;

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.S) || Grounded == false)
        {
            ColliderTransform.localScale = Vector3.Lerp(ColliderTransform.localScale, new Vector3(1f, 0.5f, 1f), Time.deltaTime * 15f);
        }
        else
        {
            ColliderTransform.localScale = Vector3.Lerp(ColliderTransform.localScale, new Vector3(1f, 1f, 1f), Time.deltaTime * 15f);
        }

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
            if (Rigidbody.velocity.x > MaxSpeed && Input.GetAxisRaw("Horizontal") > 0)
            {
                speedMultiplier = 0;
            }

            if (Rigidbody.velocity.x < -MaxSpeed && Input.GetAxisRaw("Horizontal") < 0)
            {
                speedMultiplier = 0;
            }
        }


        Rigidbody.AddForce(Input.GetAxis("Horizontal") * MoveSpeed * speedMultiplier * Vector3.right, ForceMode.VelocityChange);

        if (Grounded)
        {
            Rigidbody.AddForce(-Rigidbody.velocity.x * Friction, 0, 0, ForceMode.VelocityChange);

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
