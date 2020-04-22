using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float moveSpeed;
    // Update is called once per frame
    void Update ()
    {
       transform.position += transform.forward * Time.deltaTime * moveSpeed;
    }
}
