using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string location = "Australia";
        location = "H";

        int health = 50;
        float moveSpeed = 2.5f;
        bool canMove = true;

        health += 20;
        moveSpeed -= 1.0f;

        if(location == "Australia")
        {
            Debug.Log("Condition is true.");
        }
        else if (location == "America")
        {

        }
        else
        {
            //codetest
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}