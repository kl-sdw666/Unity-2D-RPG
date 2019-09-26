using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewArea : MonoBehaviour
{
    //LoadNewArea variables
    public string levelToLoad;
    public string exitPoint;
    private PlayerController thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //this method is called when an object (The player) collides with the new area trigger objects
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            Application.LoadLevel(levelToLoad);
            thePlayer.startPoint = exitPoint;
        }
    }
}
