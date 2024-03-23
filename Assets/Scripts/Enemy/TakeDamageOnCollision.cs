using UnityEngine;

public class TakeDamageOnCollision : MonoBehaviour
{

    public EnemyHealth EnemyHealth;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody)
        {
            if (collision.rigidbody.GetComponent<Bullet>() != null)
            {
                EnemyHealth.TakeDamage(1);
            }
        }
    }
}
