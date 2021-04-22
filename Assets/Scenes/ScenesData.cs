using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static ScenesData;

public enum AreaType
{
    _Forest,
    _City,
    _ForestNight,
    _Sky,
    _Castle,
    _Mine,
    _Noir,
    _Space

}

//unity made like almost all this infestructure i'm nto remaking the wheel. 
//https://bit.ly/3gp3POa
//goes to a blog post about saving and loading.

[CreateAssetMenu(fileName = "sceneDB", menuName = "Scene Data/Database")]
public class ScenesData: ScriptableObject
{
    public List<Level> levels = new List<Level>();
    public List<Menu> menus = new List<Menu>();
    public int CurrentLevelIndex = 1;
    
    public AreaType _AreaType;

    [SerializeField]
    public ScenesData nextDB;

    /*
     * Levels
     */

    //Load a scene with a given index
    public void LoadLevelWithIndex(int index)
    {
        if(index <= levels.Count)
        {
            //Load Gameplay scene for the level
            SceneManager.LoadSceneAsync("PlayerControllerScene");
            //Load first part of the level in additive mode
            SceneManager.LoadSceneAsync("Base"+CurrentLevelIndex.ToString()+_AreaType.ToString(), LoadSceneMode.Additive);
        }
        //reset the index if we have no more levels
        else
        {
            CurrentLevelIndex =1;
            Debug.Log("we did it all died");

            //nextDB.NewGame();
        }
            
    }
    //Start next level
    public void NextLevel()
    {
        CurrentLevelIndex++;
        LoadLevelWithIndex(CurrentLevelIndex);
    }
    //Restart current level
    public void RestartLevel()
    {
        LoadLevelWithIndex(CurrentLevelIndex);
    }
    //New game, load level 1
    public void NewGame()
    {
        LoadLevelWithIndex(1);
    }

    /*
     * Menus
     */

    //Load main Menu
    public void LoadMainMenu()
    {
        SceneManager.LoadSceneAsync(menus[(int)Type.Main_Menu].sceneName);
    }
    //Load Pause Menu
    public void LoadPauseMenu()
    {
        SceneManager.LoadSceneAsync(menus[(int)Type.Pause_Menu].sceneName);
    }
}


