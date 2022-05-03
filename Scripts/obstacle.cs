using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obstacle : MonoBehaviour
{
    public GameObject UI;
    public int life =100;
    public Text lifetext;
    public GameObject parent;
    
    
    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(false);
        life = 100;
    }
    private void Update()
    {
        // displays the health over the obstacle
        lifetext.text = life.ToString();

       //checks if the health of current obstacle has dropped to 0 , if yes then destroys the parent obstacle .
        if( life <= 0)
        {
            Destroy(parent);
        }
        
    }

    
    void OnTriggerEnter(Collider other1)
    {
        // On Collision with the player the retry UI will be activated and timescale will be turned to 0.
        if (other1.gameObject.tag == "Player")
        {
            UI.SetActive(true);
            Time.timeScale = 0;
        }

        // On Collision with the bullet the object will lose 10 health.
        if (other1.gameObject.tag == "Bullet")
        {
            life -= 10;
        }

    }
   

}
