using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //CameraControler variables
    public GameObject followTarget;
    private Vector3 targetPosition;
    public float moveSpeed;
    private static bool cameraExist;

    //Method to ensure there is only one cameraObject
    void destroyDuplicate()
    {
        if (!cameraExist)
        {
            cameraExist = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //Method to target the player
    void cameraTarget()
    {
        targetPosition = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);

    }

    // Start is called before the first frame update
    void Start()
    {
        destroyDuplicate();
    }   

    // Update is called once per frame
    void Update()
    {
        cameraTarget();
    }
}
