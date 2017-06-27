using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class RenderDepth : MonoBehaviour
{
    void OnEnable()
    {
        GetComponent<Camera>().depthTextureMode = DepthTextureMode.DepthNormals;
    }
}