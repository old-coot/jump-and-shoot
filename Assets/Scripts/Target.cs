using UnityEngine;

public class Target : MonoBehaviour
{
    public Transform TargetTransform;

    private void Update()
    {
        transform.position = TargetTransform.position;
    }
}
