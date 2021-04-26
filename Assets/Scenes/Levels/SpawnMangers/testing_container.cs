using System;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Spawnaeebles", menuName = "thingie")]
public class testing_container : ScriptableObject
{

    [SerializeField] public List<EnemySpawn> enemyListering;

[Serializable]
public class EnemySpawn
{
    [SerializeField]public GameObject enemy;
    public float x;
    public float y;

}
}
