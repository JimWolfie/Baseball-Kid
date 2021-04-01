using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ludiq;
using Bolt;

public class BoltTrigger : MonoBehaviour
{
    
    public GameObject player;

    public void attack(string attackName)
    {
       

        CustomEvent.Trigger(player, attackName);
    }


}
