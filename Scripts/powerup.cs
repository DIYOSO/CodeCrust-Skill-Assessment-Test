using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    public int power = 0;
    
    //Increases the value of power for 3 secs if it collides with player. The value of power is used in bullet script to increase the bullet distance

    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            power = 5;
            yield return new WaitForSeconds(3.0f);
            power = 0;
        }
    }
}
   
