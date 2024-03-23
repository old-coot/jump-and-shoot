using UnityEngine;

public class LootHeal : MonoBehaviour
{
    public int HealthValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.GetComponent<PlayerHealth>() != null)
        {
            other.attachedRigidbody.GetComponent<PlayerHealth>().AddHealth(HealthValue);
            Destroy(gameObject);
        }
    }
}
