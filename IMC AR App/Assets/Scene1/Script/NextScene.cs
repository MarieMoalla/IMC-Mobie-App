using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string sceneName;
    private string targetScene;

   
    public void Load_Scene()
    {
         targetScene = sceneName;
         SceneManager.LoadSceneAsync(targetScene);
         
    }
}
