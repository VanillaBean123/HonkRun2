using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GlobalLightChanger : MonoBehaviour
{
    public Color startcolour;
    public Color endcolour;

    public float startposition;
    public float endposition;
    public Light2D globalLight;

    // Update is called once per frame
    void Update()
    {
        float t = (transform.position.x / endposition);
        globalLight.color = Color.Lerp(startcolour, endcolour, t);   
    }
}
