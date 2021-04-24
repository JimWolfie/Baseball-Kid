using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Options", menuName ="options")]
public class OptionsSO : ScriptableObject
{
    public  int timeScalePrefs;
    public bool isPaused;
    public bool isOptions;
    public int width;
    public int hieght;
    public FullScreenMode windowMode= FullScreenMode.Windowed;


    public bool _isPaused
    {
        get => isPaused;
        set => isPaused = value;
    }

    public bool _isOptions
    {
        get=>isOptions;
        set=> isOptions = value;
    }
    public int _timeScalePrefs
    {
        get=>timeScalePrefs;
        set=> timeScalePrefs = value;
    }
    public void ResolutionSet(int _width, int _height)
    {
        width = _width;
        hieght = _height;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadSceneAsync("Loader");
        SceneManager.LoadSceneAsync("Main_Menu", LoadSceneMode.Additive);
    }
    //Load Pause Menu
    public void Pause()
    {
        if(_isPaused == true)
        {
            _isPaused = false;
            Time.timeScale = _timeScalePrefs;
            LoadUnPause();
            
            //togglePause.Raise();

        }
        if(_isPaused == false)
        {
            _isPaused = true;
            Time.timeScale = 0;

            LoadPause();

        }

    }
    public void Options()
    {
        if(_isOptions == true)
        {
            _isOptions = false;
            LoadUnOptions();
            
            
            //toggleOptions.Raise();

        }
        
        else 
        {
            _isOptions = true;
            LoadOptions();
        }
    }


    public void LoadPause()
    {
        AsyncOperation loader = SceneManager.LoadSceneAsync("Pause_Menu", LoadSceneMode.Additive);

       

    }
    public void LoadUnPause()
    {
        AsyncOperation loader = SceneManager.UnloadSceneAsync("Pause_Menu");
    }

    public void LoadOptions()
    {
        AsyncOperation loader = SceneManager.LoadSceneAsync("Options", LoadSceneMode.Additive);

        
    }
    public void LoadUnOptions()
    {
        AsyncOperation loader = SceneManager.UnloadSceneAsync("Options");

    }


    public void Quit(){
#if UNITY_EDITOR
        Debug.Log("hello World");
#endif
#if UNITY_STANDALONE
    
        Application.Quit();

#endif
    }
}


