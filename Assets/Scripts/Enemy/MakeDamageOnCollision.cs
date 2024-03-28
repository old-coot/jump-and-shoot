using UnityEngine;

public class MakeDamageOnCollision : MonoBehaviour
{
    public int DamageValue = 1;

    private void OnCollisionEnter(Collision collision)
    {
        PlayerHealth playerHealth = collision.collider.GetComponentInParent<PlayerHealth>();
        if (playerHealth)
        {
            collision.rigidbody.GetComponent<PlayerHealth>().TakeDamage(DamageValue);
        }
        
    }
}
