using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spawnablesx", menuName = "enemy data Containers")]
public class Spawnablesx : ScriptableObject
{
    public List<EnemySpawnPoint> enemyArray;

    
   
}
[Serializable]
public struct EnemySpawnPoint
{
    public string Name;
    public float x;
    public float y;

}

