using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    //Movement Target
    public Vector3 target;

    //Speed
    public float speed = 1;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //calculate the distance from target
        float distance = Vector3.Distance(transform.position, target);
        //have we arrived?
            if (distance > 0)
            {
                //calculate how much we need to move (step) d = v * t
                float step = speed * Time.deltaTime;
                //move by that step
                transform.position = Vector3.MoveTowards(transform.position, target, step);
            }
    }
}
