using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RotateToTargetEuler : MonoBehaviour
{
    public Vector3 LeftEuler;
    public Vector3 RightEuler;
    public float RotateSpeed;
    private Vector3 _targetEuler;

    
    private void Update() {
        transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(_targetEuler), Time.deltaTime * RotateSpeed);
    }

    public void RotateLeft(){
        _targetEuler = LeftEuler;
    }
    public void RotateRight(){
        _targetEuler = RightEuler;
    }
}
