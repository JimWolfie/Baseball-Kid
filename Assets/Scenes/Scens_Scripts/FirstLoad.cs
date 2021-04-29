using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstLoad : MonoBehaviour
{
    private void Update()
    {
        if(Input.anyKey)
        {
            SceneManager.LoadSceneAsync("Loader");
            SceneManager.LoadSceneAsync("Main_Menu", LoadSceneMode.Additive);
        }
    }
}
