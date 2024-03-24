using UnityEngine;

public class Rabbit : MonoBehaviour
{
    public float AttackPeriod = 7f;
    public Animator Animator;
    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > AttackPeriod)
        {
            _timer = 0;
            Animator.SetTrigger("Attack");
        }
    }
}
