using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FishCollision : MonoBehaviour
{
    int missingFish = 0;
    private void OnTriggerEnter(Collider col)
    {
        switch (col.tag)
        {
            case "fish":


                if (col.gameObject.GetComponent<FindRT>().myRenderTexture == ScriptInfrastructure.instance.whichFish.texture)
                {
                    Debug.Log("Win");
                    SceneManager.LoadScene("Scene2");
                }
                else
                {
                    Debug.Log("antiPog");
                    SceneManager.LoadScene("Scene2");
                }
                Destroy(col.gameObject);
                Destroy(ScriptInfrastructure.instance.whichFish);

                
                


                break;
        }

    }
}
