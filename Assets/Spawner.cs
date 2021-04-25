using System.Collections;
using UnityEngine;
using SOEvents;
using Bolt;
using System;

public class Spawner : MonoBehaviour
{
    public testing_container _enemyList;
   
    [SerializeField]private int index;
    [SerializeField]private int totalE;
    public float delay_between_waves;
    
    public GameObject startPos;
    public Vector3Event setPlayerPos;
    
    //public string Next_Scene_By_Name;
    //List<AsyncOperation> scenesToLoad = new List<AsyncOperation>();

    public VoidEvent allDead;

    private GameObject lastprefab = null;

    private void OnEnable()
    {
        index =0;
        totalE = _enemyList.enemyListering.Count;
    }
    private void Start()
    {
         SpawnNew(0);
         setPlayerPos.Raise(startPos.transform.position);
    }


    void SpawnNew(int i)
    {
        
        var q = _enemyList.enemyListering[i];
        var u = q.enemy;

        if(lastprefab != null)
        {
           // Destroy(lastprefab);
        }
        var g =Instantiate(u, new Vector3(q.x, q.y, 0), Quaternion.identity, gameObject.transform);
        lastprefab = g;

    }
    public void allClear()
    {

       allDead.Raise();
       
    }

    public void somethingDied()
    {
        
        if(index >= totalE)
        {
            if(lastprefab != null)
            {
                //Destroy(lastprefab);
            }
            allClear();
            
            
        } else
        {
            SpawnNew(index);
        }
        index++;
    }

    
}
