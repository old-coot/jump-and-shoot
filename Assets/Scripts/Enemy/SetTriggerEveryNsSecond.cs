using UnityEngine;

public class SetTriggerEveryNsSecond : MonoBehaviour
{
    public float Period = 3f;
    public Animator Animator;
    public string TriggerName;
    private float _timer;
    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > Period)
        {
            _timer = 0;
            Animator.SetTrigger(TriggerName);
        }
    }
}
