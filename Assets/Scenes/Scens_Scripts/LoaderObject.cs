using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="scenes in build", menuName = "scene builder")]
public class LoaderObject : ScriptableObject
{
    List<string> scenesCurrentlyLoaded = new List<string>();
}
