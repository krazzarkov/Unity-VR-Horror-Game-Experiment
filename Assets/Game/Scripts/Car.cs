using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public GameObject tire;
    public GameObject carBroken;
    public GameObject carFixed;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tire")
        {
            carBroken.SetActive(false);
            carFixed.SetActive(true);
            tire.SetActive(false);
            Destroy(tire);
        }
    }
}
