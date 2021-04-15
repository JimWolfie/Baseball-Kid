using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public testing_container _enemyList;
   
    public int index;
    public int totalE;
    public float delay_between_waves;
    
    public string Next_Scene_By_Name;
    List<AsyncOperation> scenesToLoad = new List<AsyncOperation>();

    private void OnEnable()
    {
        index =0;
        totalE = _enemyList.enemyListering.Count;
    }
   
   

    void SpawnNew(int i)
    {
        
        var q = _enemyList.enemyListering[i];
        var u = q.enemy;
        Instantiate(u, new Vector3(q.x, q.y, 0), Quaternion.identity);
        
    }

    public void Reload(string nextScene)
    {
        scenesToLoad.Add(SceneManager.UnloadSceneAsync("PlayerControllerScene"));
        scenesToLoad.Add(SceneManager.LoadSceneAsync("PlayerControllerScene"));
        scenesToLoad.Add(SceneManager.LoadSceneAsync(nextScene, LoadSceneMode.Additive));
       
       StartCoroutine(sadTime());
    }
    public IEnumerator sadTime()
    {
        for(int i = 0; i<scenesToLoad.Count; ++i)
        {
            yield return null;
        }
    }
    public void somethingDied()
    {
        index++;
        if(index >= totalE)
        {
            Reload(Next_Scene_By_Name);
        } else
        {
            SpawnNew(index);
        }
    }
}
