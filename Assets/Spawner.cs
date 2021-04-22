using System.Collections;
using UnityEngine;
using SOEvents;

public class Spawner : MonoBehaviour
{
    public testing_container _enemyList;
   
    [SerializeField]private int index;
    [SerializeField]private int totalE;
    public float delay_between_waves;
    
    
    //public string Next_Scene_By_Name;
    //List<AsyncOperation> scenesToLoad = new List<AsyncOperation>();

    public VoidEvent allDead;

    private void OnEnable()
    {
        index =0;
        totalE = _enemyList.enemyListering.Count;
    }
   
   

    void SpawnNew(int i)
    {
        
        var q = _enemyList.enemyListering[i];
        var u = q.enemy;
        Debug.Log(q.enemy.name);
        Debug.Log(q.x);
        Debug.Log(q.y);
        
        Instantiate(u, new Vector3(q.x, q.y, 0), Quaternion.identity);

    }

    
    public void somethingDied()
    {
        
        if(index >= totalE)
        {
            allDead.Raise();
        
        } else
        {
            SpawnNew(index);
        }
        index++;
    }
}
