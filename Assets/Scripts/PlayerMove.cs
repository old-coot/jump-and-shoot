using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float MoveSpeed;
    public float JumpSpeed;
    public float Friction;
    public bool Grounded;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.AddForce(0, JumpSpeed, 0, ForceMode.VelocityChange);
        }
    }

    private void FixedUpdate()
    {
        Rigidbody.AddForce(Input.GetAxis("Horizontal") * MoveSpeed, 0, 0, ForceMode.Acceleration);
        Rigidbody.AddForce(-Rigidbody.velocity.x * Friction, 0, 0, ForceMode.Acceleration);
    }

}
