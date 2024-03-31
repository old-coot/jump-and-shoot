using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPlayer : MonoBehaviour
{
    public Vector3 LeftEuler;
    public Vector3 RightEuler;
    public float RotationSpeed = 5f;

    private Transform _playerTransform;
    private Vector3 _targetEuler;

    private void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().transform;
    }

    private void Update()
    {
        if (transform.position.x < _playerTransform.position.x)
        {
            _targetEuler = RightEuler;
        }
        else
        {
            _targetEuler = LeftEuler;
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(_targetEuler), Time.deltaTime * RotationSpeed);
    }

}
