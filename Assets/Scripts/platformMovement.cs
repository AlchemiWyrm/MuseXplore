using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Spawns platforms off screen and removes them when they leave the screen for most efficient memory use
//Controls the movement + speed of the platforms
//Will probably need to be linked to keysToSound where player movement works to check when right button is pressed?

public class platformMovement : MonoBehaviour
{
    public float movementSpeed = 3;
    public GameObject platform;
    public GameObject hitLine;
    public bool reachPlatform;
    public Vector3 targetPos;
    public Vector3 hitPos;
    public float smoothTime = 0.1f;
    public Vector3 velocity;
    public bool correctButton;
    //off screen position for spawning notes
    public Vector3 offScreenPos1 = new Vector3(14, -2, -6);
    //off screen position for despawning notes
    public Vector3 offScreenPos2 = new Vector3(-14, -2, -6);

    // Start is called before the first frame update
    void Start()
    {
        platform = GameObject.Find("note");
        targetPos = platform.GetComponent<Transform>().position;
        hitLine = GameObject.Find("centre line");
        hitPos = hitLine.GetComponent<Transform>().position;
        targetPos.x = hitPos.x;
        correctButton = false;
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{

    //}

    void movement()
    {
        //platform.transform.position = Vector3.MoveTowards(platform.transform.position, targetPos, movementSpeed * Time.deltaTime);
        platform.transform.position = Vector3.SmoothDamp(platform.transform.position, targetPos, ref velocity, smoothTime, movementSpeed);
    }

    void spawn()
    {
        //create note off screen (right / offscreenpos1)
    }

    void despawn()
    {
        //destroy note off screen (left / offscreenpos2)
    }
    bool correctButtonCheck()
    {
        if (Input.GetKey(KeyCode.D))
        {
            return true;
        }
        return false;
    }

    //Update is called once per frame 
    void Update()
    {
        movement();
        correctButtonCheck();
        if (correctButtonCheck())
        {
            targetPos = offScreenPos2;
        }
        else 
        { 
            //slow down movement?
        }
    }
}

////notes should remain the same distance from each other
////notes stop moving if collison occurs and players don't press the right key
////we'll make them slow down when we get this to work

//if (reachPlatform == true)
//{
//    Debug.Log("reached platform!! press key to continue");
//    if (Input.GetKey(KeyCode.A))
//    {
//        //platformPos.x -= movementSpeed * Time.deltaTime;
//        platform.transform.Translate(new Vector3(-2, 0, 0) * movementSpeed * Time.deltaTime);
//        //platform.transform.position = platformPos;
//    }
//}
//else if (reachPlatform == false)
//{
//    //platformPos.x -= movementSpeed * Time.deltaTime;
//    platform.transform.Translate(new Vector3(-2, 0, 0) * movementSpeed * Time.deltaTime);
//    //platform.transform.position = platformPos;
//}