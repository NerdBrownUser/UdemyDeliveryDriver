using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.0f;
    [SerializeField] float moveSpeed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Driver");
    }

    // Update is called once per frame
    void Update()
    {
        float steer = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(0.0f, move, 0.0f);
        transform.Rotate(0.0f, 0.0f, -steer);
    }
}