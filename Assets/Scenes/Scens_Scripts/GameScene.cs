using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene: ScriptableObject
{
    [Header("Information")]
    public string sceneName;
    public string shortDescription;

    public string _name => sceneName;
}
