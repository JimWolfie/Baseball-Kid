using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ludiq;
using Bolt;
using UnityEngine.SceneManagement;

public class BoltTrigger : MonoBehaviour
{
    
    public GameObject player;

    public void attack(string attackName)
    {
       

        CustomEvent.Trigger(player, attackName);
    }

    public void death()
    {
        
        SceneManager.LoadSceneAsync("Game_Over", LoadSceneMode.Additive);
        
    }
    public void test()
    {
        
    }
}
