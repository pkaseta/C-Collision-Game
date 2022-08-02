using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    Rigidbody rigidBody;
    MeshRenderer renderer; 
    [SerializeField] float timeToWait = 3f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait){
            //Set Object to appear and fall after 5 seconds
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
