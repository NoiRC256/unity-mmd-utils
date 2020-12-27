using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalManager : MonoBehaviour
{
    // For non-HDR colors, remove [ColorUsageAttribute...]
    [SerializeField] [ColorUsageAttribute(true, true, 0f, 8f, 0.125f, 3f)] private Color color1;
    [SerializeField] [ColorUsageAttribute(true, true, 0f, 8f, 0.125f, 3f)] private Color color2;
    [SerializeField] [ColorUsageAttribute(true, true, 0f, 8f, 0.125f, 3f)] private Color color3;

    private void Awake()
    {
        // Limit framerate to 60fps;
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 60;
    }

    public void UpdateAmbientColor(int i)
    {
        switch(i){
            case 1:                                        
                RenderSettings.ambientLight = color1;      
                break;
            case 2:
                RenderSettings.ambientLight = color2;
                break;
            case 3:
                RenderSettings.ambientLight = color3;
                break;
        }
    }

}
