using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject FinishUI;
    // Start is called before the first frame update
    private void Start()
    {
        FinishUI.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        // On Collision with the player the the game will come to an end and Finish UI will be activated

        if (other.gameObject.tag == "Player")
        {
            FinishUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
