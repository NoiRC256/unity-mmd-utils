using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private List<Camera> cameras;
    [SerializeField] private Transform target;
    [SerializeField] private float baseFOV = 20f;
    [SerializeField] private float minFOV = 10f;
    [SerializeField] private float maxFOV = 120f;


    private void Awake()
    {
        // Get Camera component of each children;
        for(int i=0; i< transform.childCount; i++)
        {
            cameras.Add(transform.GetChild(i).GetComponent<Camera>());
        }

        // Initialize camera FoV;
        foreach (Camera cam in cameras)
        {
            cam.fieldOfView = baseFOV;
        }

        // Set background video height = camera height;
        target.position = new Vector3(target.position.x, transform.position.y, target.position.z);
    }

    private void Update()
    {
        // Update camera FoV (with clamping) according to self position z;
        foreach (Camera cam in cameras)
        {
            cam.fieldOfView = Mathf.Clamp(baseFOV + 5 * (transform.position.z - 30f), minFOV, maxFOV);
        }
    }



}
