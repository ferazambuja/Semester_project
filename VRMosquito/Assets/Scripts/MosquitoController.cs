using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosquitoController : MonoBehaviour
{
    // vr interactive item
    VRInteractiveItem vrIntItem;

    // rigidbody
    Rigidbody rb;

    // flag to keep track whether this mosquito is moving
    bool isMoving = true;
    
    // Start is called before the first frame update
    void Awake()
    {
        //grab my vr interactive component
        vrIntItem = GetComponent<VRInteractiveItem>();

        //grab the rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    // when our game object is enabled
    void OnEnable()
    {
        vrIntItem.OnClick += HandleClick;    
    }

   // when our game object is disabled
    void OnDisable()
    {
        vrIntItem.OnClick -= HandleClick;
    }
    
    // this is called when the mosquito is clicked on
    void HandleClick()
    {
        // check that it's moving
        if(rb.isKinematic)
        {
            // rotate it's transform
            transform.Rotate(new Vector3(0, 0, 180));

            // disable kinematic property
            rb.isKinematic = false;

            // set the flag to false
            isMoving = false;            
        }
    }
        
    
}
