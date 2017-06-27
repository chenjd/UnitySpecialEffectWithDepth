using UnityEngine;
using System.Collections;
using UnityEditor;

[ExecuteInEditMode]
public class RenderDepthMap : MonoBehaviour {

    public Material mat;

	// Use this for initialization
	void Start () {

        Camera.main.depthTextureMode = DepthTextureMode.Depth;

	}

    void OnRenderImage(RenderTexture src, RenderTexture des)
    {
        Graphics.Blit(src, des, mat);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
