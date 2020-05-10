using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tire : MonoBehaviour
{
    public GameObject win;
    public GameObject carBroken;
    public GameObject carFixed;

    // Update is called once per frame
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            win.SetActive(true);
            carBroken.SetActive(false);
            carFixed.SetActive(true);
            Destroy(gameObject);
        }
    }
}
