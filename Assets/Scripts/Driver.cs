using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200.0f;
    [SerializeField] float moveSpeed = 20.0f;
    [SerializeField] float boostSpped = 20.0f;
    [SerializeField] float bumpSpeed = 20.0f;

    float currentSpeed;
    float speedTimer;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Driver");

        currentSpeed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        speedTimer -= Time.deltaTime;

        if (speedTimer <= 0)
            currentSpeed = moveSpeed;

        float steer = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float move = Input.GetAxis("Vertical") * currentSpeed * Time.deltaTime;

        transform.Translate(0.0f, move, 0.0f);
        transform.Rotate(0.0f, 0.0f, -steer);
    }

    public void SetBooster(float time)
    {
        currentSpeed = boostSpped;
        speedTimer = time;
    }

    public void SetBumper(float time)
    {
        currentSpeed = bumpSpeed;
        speedTimer = time;
    }
}