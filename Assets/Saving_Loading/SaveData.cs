using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class SaveData
{

    [System.Serializable]
    public struct Savable{
        public string playerSceneName; //the scene name of the player we're using.
        public int reloadTime;
        public float health;
        public int cardHashValue;
        public string mostRecentBase;
    }

    public string ToJson()
    {
        return JsonUtility.ToJson(this);
    }
    public void LoadFromJson(string Json)
    {
        JsonUtility.FromJsonOverwrite(Json, this);
    }


}
public interface ISaveable
{
    void PopulateSaveData(SaveData a_SaveData);
    void LoadFromSaveData(SaveData a_SaveData);
}