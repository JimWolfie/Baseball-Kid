using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SerilizeManager 
{
    public static void SaveJsonData(IEnumerable<ISaveable> Saveables)
    {
        SaveData sd = new SaveData();
        foreach(var saveable in Saveables)
        {
            saveable.PopulateSaveData(sd);
        }

        if(FileManager.WriteToFile("SaveData01.dat", sd.ToJson()))
        {
            Debug.Log("Save successful");
        }
    }

    public static void LoadJsonData(IEnumerable<ISaveable> Saveables)
    {
        if(FileManager.LoadFromFile("SaveData01.dat", out var json))
        {
            SaveData sd = new SaveData();
            sd.LoadFromJson(json);

            foreach(var saveable in Saveables)
            {
                saveable.LoadFromSaveData(sd);
            }

            
        }
    }

}
