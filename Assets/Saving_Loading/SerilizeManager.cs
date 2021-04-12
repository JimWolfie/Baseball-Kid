using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SerilizeManager : MonoBehaviour
{
    public static bool Save(string saveName, SaveData saveData)
    {
        string json = JsonUtility.ToJson(saveData);

        if(!Directory.Exists(Application.persistentDataPath +"/saves"))
        {
            Directory.CreateDirectory(Application.persistentDataPath +"/saves");
        }
        string path = Application.persistentDataPath +"/saves/"+ saveName + ".save";

        
        return true;
    }

    public static object Load(string path)
    {
        if(!File.Exists(path))
        {
            return null;
        }
        BinaryFormatter formatter = GetBinaryFormatter();
        FileStream file = File.Open(path, FileMode.Open);

        try
        {
            object save = formatter.Deserialize(file);
            file.Close();
            return save;
        } catch
        {
            Debug.LogErrorFormat("Failed to load file at {0}", path);
            file.Close();
            return null;
        }
    }
    public static BinaryFormatter GetBinaryFormatter()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        return formatter;
    }

    public void savePrefs()
    {

    }
 
}
