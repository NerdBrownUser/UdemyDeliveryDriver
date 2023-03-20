using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverySystem : MonoBehaviour
{
    [SerializeField] Color32 packageColor;
    [SerializeField] float destroyDelay = 0.5f;

    bool hasPackage = false;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Crash");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == null)
            return;

        if (collision.tag == "Package" && hasPackage == false)
        {
            Debug.Log("Package picked up.");

            Destroy(collision.gameObject, destroyDelay);

            hasPackage = true;

            if (spriteRenderer != null)
                spriteRenderer.color = packageColor;
        }
        else if (collision.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Package deliveried.");

            hasPackage = false;

            if (spriteRenderer != null)
                spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f);
        }
        else if (collision.tag == "Booster")
        {
            Debug.Log("Booster!");

            GetComponent<Driver>().SetBooster(5.0f);
        }
        else if (collision.tag == "Bumper")
        {
            Debug.Log("Bumper..");

            GetComponent<Driver>().SetBumper(5.0f);
        }
    }
}