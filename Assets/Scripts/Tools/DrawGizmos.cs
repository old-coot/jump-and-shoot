using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmos : MonoBehaviour
{
    private void OnDrawGizmos()

    {

        Ray ray = new Ray(transform.position, transform.forward);

        Gizmos.DrawRay(ray);

    }
}
