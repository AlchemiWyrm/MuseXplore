using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This code will bind the piano keyboard sounds to the computer keyboard.
//May as well add the player movement here too since buttons = player move + make sound
//maybe check out https://www.youtube.com/watch?v=K4dKsIJnh1c&ab_channel=MKGamesArt%26Visuals!!!
//

public class keysToSound : MonoBehaviour
{

    public GameObject chara;
    public Vector3 charaPos;
    

    // Start is called before the first frame update
    void Start()
    {
        chara = GameObject.Find("character");
        charaPos = chara.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //moves character
            charaPos = new Vector3(0, -2, 0);
            chara.transform.position = charaPos;
            //plays sound
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //moves character
            charaPos = new Vector3(0, -1, 0);
            chara.transform.position = charaPos;
            //plays sound
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //moves character
            charaPos = new Vector3(0, 0, 0);
            chara.transform.position = charaPos;
            //plays sound
        }
        else if (Input.GetKey(KeyCode.F))
        {
            //moves character
            charaPos = new Vector3(0, 1, 0);
            chara.transform.position = charaPos;
            //plays sound
        }
        else if (Input.GetKey(KeyCode.G))
        {
            //moves character
            charaPos = new Vector3(0, 2, 0);
            chara.transform.position = charaPos;
            //plays sound
        }
        else if (Input.GetKey(KeyCode.H))
        {
            //moves character
            charaPos = new Vector3(0, 3, 0);
            chara.transform.position = charaPos;
            //plays sound
        }
        else if (Input.GetKey(KeyCode.J))
        {
            //moves character
            charaPos = new Vector3(0, 4, 0);
            chara.transform.position = charaPos;
            //plays sound
        }
        else if (Input.GetKey(KeyCode.K))
        {
            //moves character
            charaPos = new Vector3(0, 5, 0);
            chara.transform.position = charaPos;
            //plays sound
        }
        else if (Input.GetKey(KeyCode.L))
        {
            //moves character
            charaPos = new Vector3(0, 6, 0);
            chara.transform.position = charaPos;
            //plays sound
        }

    }
}
