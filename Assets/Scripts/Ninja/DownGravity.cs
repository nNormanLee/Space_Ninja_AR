using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownGravity : MonoBehaviour
{

    public PlayerMovement movement;
    float dt = 0.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    { 
        if (dt > 2.0f)
        {
            dt = 0.0f;
            movement.enabled = true;
        }

        if (movement.enabled == false)
        {
            dt += Time.deltaTime;
        }
        //Debug.Log(dt);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Downer")
            {
            GetComponent<Rigidbody>().useGravity = true;
            movement.enabled = false;
            GetComponent<Rigidbody>().drag = 0;
            
            }

       
        
    }


}
