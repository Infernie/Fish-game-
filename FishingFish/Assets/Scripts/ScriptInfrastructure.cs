using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptInfrastructure : MonoBehaviour
{
    public static ScriptInfrastructure instance;

    private void Awake()
    {
        instance = this;
    }

    #region Assets
    public GameObject hook;
    public RenderTexture[] fishRts = new RenderTexture[10];
    public GameObject[] fish = new GameObject[7];
    public GameObject[] RTCameras = new GameObject[7];
    public RawImage whichFish;
    #endregion
    #region Scripts
    #endregion
}
