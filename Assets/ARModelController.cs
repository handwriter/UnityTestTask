using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARModelController : MonoBehaviour
{
    public GameObject trackingObject;

    void Start()
    {
        
    }

    private void OnEnable()
    {
        ImageTracking.OnTrackedImageChanged += TrackedImageChanged;
    }

    private void OnDisable()
    {
        ImageTracking.OnTrackedImageChanged -= TrackedImageChanged;
    }

    public void TrackedImageChanged(ARTrackedImage trackedImage)
    {
        switch (trackedImage.trackingState)
        {
            case TrackingState.Limited:
                trackingObject.SetActive(false);
                break;
            case TrackingState.Tracking:
                trackingObject.SetActive(true);
                trackingObject.transform.position = trackedImage.transform.position;
                trackingObject.transform.localEulerAngles = trackedImage.transform.localEulerAngles;
                break;
        }
    }
}
