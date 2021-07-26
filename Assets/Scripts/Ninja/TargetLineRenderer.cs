using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLineRenderer : MonoBehaviour
{
    
    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, playerMovement.attractor.transform.position);
        lineRenderer.SetPosition(1, playerMovement.FindJumpPoint());
        lineRenderer.SetPosition(2, playerMovement.target.transform.position);

    }
}
