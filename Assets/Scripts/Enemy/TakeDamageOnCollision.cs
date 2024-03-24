using UnityEngine;

public class TakeDamageOnCollision : MonoBehaviour
{

    public EnemyHealth EnemyHealth;
    public bool DieOnAnyCollision;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody)
        {
            if (collision.rigidbody.GetComponent<Bullet>() != null)
            {
                EnemyHealth.TakeDamage(1);
            }
        }

        if (DieOnAnyCollision)
        {
            EnemyHealth.TakeDamage(10000);
        }
    }
}
