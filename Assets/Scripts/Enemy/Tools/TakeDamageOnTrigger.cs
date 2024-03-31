using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageOnTrigger : MonoBehaviour
{
    public EnemyHealth EnemyHealth;
    public bool DieOnAnyCollision;

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
        {
            if (other.attachedRigidbody.GetComponent<Bullet>() != null)
            {
                EnemyHealth.TakeDamage(1);
            }
        }

        if (DieOnAnyCollision)
        {
            if (other.isTrigger == false)
            {
                EnemyHealth.TakeDamage(10000);
            }
        }
    }

}
