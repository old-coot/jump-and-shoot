using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float TimeScale = 0.2f;
    private float _startFixedDeltaTime;

    private void Start() {
        _startFixedDeltaTime = Time.fixedDeltaTime;
    }

    private void Update() {
        if (Input.GetMouseButton(1)){
            Time.timeScale = TimeScale;
        }
        else{
            Time.timeScale = 1f;
        }
        Time.fixedDeltaTime = _startFixedDeltaTime * Time.timeScale;
    }
}
