using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    public int Health = 1;
    public UnityEvent EventOnTakeDamage;
    public UnityEvent EventOnDie;

    public void TakeDamage(int damageValue)
    {
        EventOnTakeDamage?.Invoke();
        Health -= damageValue;
        if (Health < 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        EventOnDie.Invoke();
    }
}
