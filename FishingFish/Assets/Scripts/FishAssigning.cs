using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAssigning : MonoBehaviour
{

    void Start()
    {
        ScriptInfrastructure.instance.whichFish.texture =
            ScriptInfrastructure.instance.fishRts[Random.Range(0, ScriptInfrastructure.instance.fishRts.Length)];
    }
}
