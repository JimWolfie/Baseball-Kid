using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type
{
    Main_Menu,
    Pause_Menu, 
    Options_Menu,
    File_Select,
    Character_Select
}

[CreateAssetMenu(fileName = "NewMenu", menuName = "Scene Data/Menu")]
public class Menu: GameScene
{
    //Settings specific to menu only
    [Header("Menu specific")]
    public Type type;

    public List<string> previouslyLoadedScenes = new List<string>();

    
    public IEnumerable GetPreviousScenesAll()
    {
        yield return previouslyLoadedScenes;
    }
}