using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsUtility : MonoBehaviour
{
    public int timeScalePrefs = 1;
    

    void Pause()
    {
        Time.timeScale = 0;
    }

    void Resume()
    {
        Time.timeScale = timeScalePrefs;
    }
    void SetSpeed(int preferedScale)
    {
        if(preferedScale <= 0) return;
        timeScalePrefs = preferedScale;
        Time.timeScale = preferedScale;
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
        SetResolutionWindowed(1920,1080);
    }
    void SetResolutionWindowed_1600_900()
    {
        SetResolutionWindowed(1600,900);
    }
    void SetResolutionWindowed_1366_768()
    {
        SetResolutionWindowed(1366,768);
    }
    void SetResolutionWindowed_1280_720()
    {
        SetResolutionWindowed(1280,720);
    }
    void SetResolutionWindowed_1024_576()
    {
        SetResolutionWindowed(1024,576);
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





}
