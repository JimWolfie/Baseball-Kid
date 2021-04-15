using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;
using Ludiq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using SOEvents;

public class OptionsUtility: MonoBehaviour
{
    public static int timeScalePrefs;
    public static bool isPaused;
    public static bool isOptions;
    public VoidEvent toggleOptions;
    public  VoidEvent togglePause;
    

    
    public void Pause()
    {
        if(isPaused == true)
        {
            StartCoroutine(LoadUnPause());
            Time.timeScale = timeScalePrefs;
            togglePause.Raise();
            
        }
        if(isPaused == false)
        {
            Time.timeScale = 0;
            togglePause.Raise();
            StartCoroutine(LoadPause());
        }
        
    }
    public void Options()
    {
        if(isPaused == true)
        {
            StartCoroutine(LoadUnOptions());
            Time.timeScale = timeScalePrefs;
            toggleOptions.Raise();

        }
        if(isPaused == false)
        {
            Time.timeScale = 0;
            toggleOptions.Raise();
            StartCoroutine(LoadOptions());
        }

    }
   
    
    public  IEnumerator LoadPause()
    {
        AsyncOperation loader = SceneManager.LoadSceneAsync("Pause_Menu", LoadSceneMode.Additive);

        while(!loader.isDone)
        {
            yield return null;
        }

    }
     public IEnumerator LoadUnPause()
    {
        AsyncOperation loader = SceneManager.UnloadSceneAsync("Pause_Menu");


        while(!loader.isDone)
        {
            yield return null;
        }

    }

    public IEnumerator LoadOptions()
    {
        AsyncOperation loader = SceneManager.LoadSceneAsync("Options", LoadSceneMode.Additive);

        while(!loader.isDone)
        {
            yield return null;
        }

    }
    public IEnumerator LoadUnOptions()
    {
        AsyncOperation loader = SceneManager.UnloadSceneAsync("Options");


        while(!loader.isDone)
        {
            yield return null;
        }
    }

        void SetSpeed(int preferedScale)
    {
        if(preferedScale <= 0)
            return;
        PlayerPrefs.SetFloat("GameSpeed", preferedScale);
        Time.timeScale = preferedScale;
    }

    public float ReturnSpeed()
    {
        return PlayerPrefs.GetFloat("GameSpeed");
    }

    

    #region resolution windowed

    void SetResolutionWindowed(int width, int height)
    {
        Screen.SetResolution(width, height, FullScreenMode.Windowed);
    }
    void SetResolutionWindowed_3840_2160()
    {
        SetResolutionWindowed(3840, 2160);
    }
    void SetResolutionWindowed_2560_1440()
    {
        SetResolutionWindowed(2560, 1440);
    }
    void SetResolutionWindowed_1920_1080()
    {
        SetResolutionWindowed(1920, 1080);
    }
    void SetResolutionWindowed_1600_900()
    {
        SetResolutionWindowed(1600, 900);
    }
    void SetResolutionWindowed_1366_768()
    {
        SetResolutionWindowed(1366, 768);
    }
    void SetResolutionWindowed_1280_720()
    {
        SetResolutionWindowed(1280, 720);
    }
    void SetResolutionWindowed_1024_576()
    {
        SetResolutionWindowed(1024, 576);
    }

    #endregion
    #region resolution FullScreen

    void SetResolutionFullScreen(int width, int height)
    {
        Screen.SetResolution(width, height, FullScreenMode.FullScreenWindow);
    }
    void SetResolutionFullScreen_3840_2160()
    {
        SetResolutionFullScreen(3840, 2160);
    }
    void SetResolutionFullScreen_2560_1440()
    {
        SetResolutionFullScreen(2560, 1440);
    }
    void SetResolutionFullScreen_1920_1080()
    {
        SetResolutionFullScreen(1920, 1080);
    }
    void SetResolutionFullScreen_1600_900()
    {
        SetResolutionFullScreen(1600, 900);
    }
    void SetResolutionFullScreen_1366_768()
    {
        SetResolutionFullScreen(1366, 768);
    }
    void SetResolutionFullScreen_1280_720()
    {
        SetResolutionFullScreen(1280, 720);
    }
    void SetResolutionFullScreen_1024_576()
    {
        SetResolutionFullScreen(1024, 576);
    }

    #endregion




    #region attack dmg


    #endregion

    
}
