using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bullletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 50f;
   
   
    // Update is called once per frame
    void Update()
    {
        //on left button click of mouse the bullets will spawn and move forward.
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(bulletPrefab, bullletSpawnPoint.position, bullletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = -bullletSpawnPoint.forward * bulletSpeed;
        }
    }
}
