using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class SaveData
{

    //this class defines what gets saved to JSON

    public string playerSceneName; //the scene name of the player we're using.
    public int reloadTime;
    public float health;
    public int cardHashValue;
    public string mostRecentBase;


}
