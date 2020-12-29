using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private List<Camera> cameras;
    [SerializeField] private float initialFOV = 20f;
    [SerializeField] private Transform bg;

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
            cam.fieldOfView = initialFOV;
        }

        // Set background video height = camera height;
        bg.position = new Vector3(bg.position.x, transform.position.y, bg.position.z);
    }

    private void Update()
    {
        // Update camera FoV according to self position z;
        foreach (Camera cam in cameras)
        {
            cam.fieldOfView = Mathf.Clamp(initialFOV + 5 * (transform.position.z - 30f), 10f, 120f);
        }
    }



}
