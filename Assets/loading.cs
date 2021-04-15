using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loading :MonoBehaviour
{
    


    public static void StartNewGam()
    {
        List<AsyncOperation> scenesToLoad = new List<AsyncOperation>();

        scenesToLoad.Add(SceneManager.LoadSceneAsync("PlayerControllerScene"));
        scenesToLoad.Add(SceneManager.LoadSceneAsync("Base1_Forest", LoadSceneMode.Additive));
        


    }
    

  
}
