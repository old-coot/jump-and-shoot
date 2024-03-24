using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 RotationSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotationSpeed * Time.deltaTime);
    }
}
