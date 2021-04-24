using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AreaType
{
    _Forest,
    _City,
    _ForestNight,
    _Sky,
    _Castle,
    _Mine,
    _Noir,
    _Space

}

[CreateAssetMenu(fileName = "NewLevel", menuName = "Scene Data/Level")]
public class Level: GameScene
{
    //Settings specific to level only
    [Header("Level specific")]
    public int enemiesCount;

    public AreaType at;

    public string areaType => at.ToString();

    
}
