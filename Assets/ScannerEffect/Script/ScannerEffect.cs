 /*
 * Created by Chenjd
 * http://www.cnblogs.com/murongxiaopifu/
 */ 
using UnityEngine;
using System.Collections;

public class ScannerEffect : MonoBehaviour
{
    #region 字段

	public Material mat;
    public float velocity = 5;
    private bool isScanning;
	private float dis;

    #endregion


    #region unity 方法

    void Start()
	{
		Camera.main.depthTextureMode = DepthTextureMode.Depth;
	}

	void Update()
	{
		if (this.isScanning)
		{
			this.dis += Time.deltaTime * this.velocity;
		}

        //无人深空中按c开启扫描
		if (Input.GetKeyDown(KeyCode.C))
		{
			this.isScanning = true;
			this.dis = 0;
		}

	}


	void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
		mat.SetFloat("_ScanDistance", dis);
        Graphics.Blit(src, dst, mat);
	}

    #endregion

}
