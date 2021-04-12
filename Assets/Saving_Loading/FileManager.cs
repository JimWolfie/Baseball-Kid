using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class FileManager 
{
    public static bool WriteToFile(string FileName, string FileContents)
    {
        var fullPath = Path.Combine(Application.persistentDataPath, FileName);

        try
        {
            File.WriteAllText(fullPath, FileContents);
            return true;
        } catch(Exception e)
        {
            Debug.LogError($"Failed to write to {fullPath} with exception {e}");
            return false;
        }
    }

    public static bool LoadFromFile(string FileName, out string result)
    {
        var fullPath = Path.Combine(Application.persistentDataPath, FileName);

        try
        {
            result = File.ReadAllText(fullPath);
            return true;
        } catch(Exception e)
        {
            Debug.LogError($"Failed to read from {fullPath} with exception {e}");
            result = "";
            return false;
        }
    }
}
