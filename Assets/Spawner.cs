using UnityEngine;
using SOEvents; //scriptable object event ssytem. 

public class Spawner : MonoBehaviour
{
    public testing_container _enemyList; //list of pefab scriptable objects
   
    [SerializeField]private int index; //set to 0 on enable
    [SerializeField]private int totalE;
    public float delay_between_waves; //not used
    
    public GameObject startPos;
    public Vector3Event setPlayerPos;
    
    //public string Next_Scene_By_Name;
    //List<AsyncOperation> scenesToLoad = new List<AsyncOperation>();

    public VoidEvent allDead; //tells the scene db to load the next level



    private void OnEnable()
    {
        index =0; //when we have no enemies in the level we move on
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

        var g =Instantiate(u, new Vector3(q.x, q.y, 0), Quaternion.identity, gameObject.transform);
       
    }
    public void allClear()
    {
        allDead.Raise();


    }
    
    public void somethingDied()
    {
        
        if(index >= totalE)
        {
           
            allClear();
            
            
        } else
        {
            SpawnNew(index);
        }
        index++;
    }

    
}
