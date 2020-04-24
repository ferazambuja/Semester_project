using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingScript : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake");
    }
    
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update every frame");
    }
    void FixedUpdate()
    {
        //Debug.Log("Fixed Update");   
    }
    void LateUpdate()
    {
        //Debug.Log("Late Update");    
    }
    private void OnEnable() 
    {
        Debug.Log("On Enable");    
    }
    void OnDisable()
    {
        Debug.Log("On Disable");            
    }
}
