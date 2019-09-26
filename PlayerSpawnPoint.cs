using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnPoint : MonoBehaviour
{
    //PlayerSpawnPoint Variables
    private PlayerController thePlayer;
    private CameraController theCamera;
    public Vector2 startDirection;
    public string pointName;

    //Method for placing player on the map
    void playerPlacement()
    {
        thePlayer = FindObjectOfType<PlayerController>();

        if (thePlayer.startPoint == pointName)
        {

            thePlayer.transform.position = transform.position;
            thePlayer.lastMove = startDirection;

            theCamera = FindObjectOfType<CameraController>();
            theCamera.transform.position = new Vector3(transform.position.x, transform.position.y, theCamera.transform.position.z);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playerPlacement();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
