using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "dbdb", menuName = "DBDB")]
public class DBDB : ScriptableObject
{
    [SerializeField]
    public ScenesData[] dbs;
}
