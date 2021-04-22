using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Options", menuName ="options")]
public class OptionsSO : ScriptableObject
{
    public  int timeScalePrefs;
    public bool isPaused;
    public bool isOptions;
    public int width;
    public int hieght;
    public FullScreenMode windowMode= FullScreenMode.Windowed;

    public void ResolutionSet(int _width, int _height)
    {
        width = _width;
        hieght = _height;
    }
}
