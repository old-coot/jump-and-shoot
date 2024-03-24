using UnityEngine;

public class CarrotCreator : MonoBehaviour
{
    public GameObject CarrrotPrefab;
    public Transform Spawn;

    public void Create()
    {
        Instantiate(CarrrotPrefab, Spawn.position, Quaternion.identity);
    }
}
