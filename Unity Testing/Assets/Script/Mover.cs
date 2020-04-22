using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    // Update is called once per frame
    void Update ()
    {
        Vector3 newPos = new Vector3(5,2,-2);
        transform.position = newPos;
    }
}
