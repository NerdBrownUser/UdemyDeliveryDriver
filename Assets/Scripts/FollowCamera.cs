using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject target;

    private void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.transform.position + Vector3.back;
        }
    }
}
