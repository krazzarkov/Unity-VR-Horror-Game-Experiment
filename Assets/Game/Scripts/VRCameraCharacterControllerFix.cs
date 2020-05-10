using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCameraCharacterControllerFix : MonoBehaviour
{

    public CharacterController character;
    public GameObject centerEyeAnchor;
    private Vector3 place;


    void FixedUpdate()
    {
        place = new Vector3(centerEyeAnchor.transform.localPosition.x, 0, centerEyeAnchor.transform.localPosition.z);

        character.center = place;
    }
}