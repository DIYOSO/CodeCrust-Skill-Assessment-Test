using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 4f;
    
    void Awake()
    {
        //gets the value of power from powerup screipt to make the lifespan of the bullet longer as a power up
        GameObject POWERUP = GameObject.Find("PowerUp");
        powerup _powerup = POWERUP.GetComponent<powerup>();
        life = life + _powerup.power;
        
        //destroys the bullets after its lifetime ( the bullet distance )
        Destroy(gameObject, life);
    }

    // on collision the bullet prefab will destory itself.
    private void OnCollisionEnter(Collision collision)
    {
       
        Destroy(gameObject);

    }
}
