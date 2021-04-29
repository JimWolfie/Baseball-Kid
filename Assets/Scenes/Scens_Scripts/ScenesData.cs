using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using static ScenesData;



//unity made like almost all this infestructure i'm nto remaking the wheel. 
//https://bit.ly/3gp3POa
//goes to a blog post about saving and loading.

[CreateAssetMenu(fileName = "sceneDB", menuName = "Scene Data/Database")]
public class ScenesData: ScriptableObject
{
    
    public List<Level> levels = new List<Level>(); //list of all the scenes from this db. 
    public List<Menu> menus = new List<Menu>(); //list of all the menus you can reach from this db
    public int CurrentLevelIndex = 1; //note for saving.    
    public AreaType _AreaType =0; //note for saving

    [SerializeField]
    public ScenesData nextDB; //mostly for gameplay

    /*
     * Levels
     */

    //Load a scene with a given index
    public void LoadLevelWithIndex(int index)
    {
        if(index <= 4)
        {
            AsyncOperation l = SceneManager.LoadSceneAsync("Loader");
            //Load Gameplay scene for the level
            var q = SceneManager.LoadSceneAsync("PlayerControllerScene", LoadSceneMode.Additive);
            //Load first part of the level in additive mode
            var p = SceneManager.LoadSceneAsync("Base"+CurrentLevelIndex.ToString()+_AreaType.ToString(), LoadSceneMode.Additive);
        }
        //reset the index if we have no more levels
        else
        {
            CurrentLevelIndex =1;
            

            NewGame();
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
        CurrentLevelIndex = 1;
       
            LoadLevelWithIndex(CurrentLevelIndex);
        
         
        
    }

    /*
     * Menus
     */

    //Load main Menu
    public void LoadMainMenu()
    {
        SceneManager.LoadSceneAsync("Loader");
        SceneManager.LoadSceneAsync("Main_Menu");
    }
    //Load Pause Menu
    public void LoadPauseMenu()
    {
        
        SceneManager.LoadSceneAsync("Pause_Menu", LoadSceneMode.Additive);
    }


    public void LoadOptionsMenu()
    {
        
        SceneManager.LoadSceneAsync("Options", LoadSceneMode.Additive);
    }
    public void UnLoadPauseMenu()
    {
        SceneManager.UnloadSceneAsync("Pause_Menu");
    }

    public void UnLoadOptionsMenu()
    {
        SceneManager.UnloadSceneAsync("Options");
    }

    
}


