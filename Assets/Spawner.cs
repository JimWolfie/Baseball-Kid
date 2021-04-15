using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Spawnablesx _enemyList;
   
    public List<EnemySpawnPoint> remaining;
    public int totalE;
    public float delay_between_waves;
    public int _waveCount;
    public string Next_Scene_By_Name;

    private void Awake()
    {
        
    }
    private void Start()
    {
        LoadRemaining();
    }

    public void LoadRemaining()
    {
        var ee = _enemyList;
        foreach(EnemySpawnPoint e in ee.enemyArray)
        {
            
            remaining.Add(e);
        }
        totalE = remaining.Count;


    }

    void spawnNew(float x, float y)
    {
        GameObject g = new GameObject();
        g.transform.position = new Vector2(x, y);
        
    }
}
