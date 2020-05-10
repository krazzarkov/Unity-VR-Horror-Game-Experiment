using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCameraCollisionFix : MonoBehaviour
{

    public GameObject OVRCameraRig;
    private VRCameraCharacterControllerFix VRCameraCharacterControllerFix;

    private void Start()
    {
        VRCameraCharacterControllerFix = OVRCameraRig.GetComponent<VRCameraCharacterControllerFix>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (TriggerVRObject(other))
            VRCameraCharacterControllerFix.enabled = false;

    }

    private void OnTriggerExit(Collider other)
    {
        if (TriggerVRObject(other))
            VRCameraCharacterControllerFix.enabled = true;

    }

    private bool TriggerVRObject(Collider other)
    {
        if (other.gameObject == OVRCameraRig)
            return true;
        else
            return false;

    }
}