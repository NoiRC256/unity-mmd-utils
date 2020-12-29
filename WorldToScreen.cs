using UnityEngine;
using UnityEngine.UI;

public class WorldToScreen : MonoBehaviour
{   
    public Transform targetObject;
    public Canvas canvas;
    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    private void Update()
    {
        rectTransform.position = Vector2.Lerp(rectTransform.position, WorldToCanvasPosition(targetObject, canvas, Camera.main), 8*Time.deltaTime);
    }
    /// <summary>
    /// Get the WorldToScreenPosition translated to be used with UI elements inside a Canvas.
    /// </summary>
    /// <param name="worldObj">Object in the world to follow.</param>
    /// <param name="canvas">Canvas transform that holds the UI object we want to move.</param>
    /// <param name="cam">Camera to calculate the screen position. If null will use Camera.main (optional).</param>
    /// <returns></returns>
    static public Vector2 WorldToCanvasPosition(Transform worldObj, Canvas canvas, Camera cam = null)
    {

        if (!cam)
        {
            cam = Camera.main;
        }

        float canvasScale = Screen.width / canvas.GetComponent<CanvasScaler>().referenceResolution.x;

        Vector3 screenPointUnscaled = cam.WorldToScreenPoint(worldObj.position);

        Vector2 screenPointScaled = new Vector2(screenPointUnscaled.x, screenPointUnscaled.y / canvas.scaleFactor);


        return screenPointScaled;
    }
}