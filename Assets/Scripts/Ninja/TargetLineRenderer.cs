using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLineRenderer : MonoBehaviour
{
    public GameObject parentObject;
    public GameObject childObject;
    
    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
       parentObject = GameObject.Find("LineRenderer");
       childObject = parentObject.transform.GetChild(0).gameObject;

    }

    // Update is called once per frame

    void FixedUpdate()
    {
        playerMovement.FindJumpPoint();

    }
    void Update()
    {
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, playerMovement.attractor.transform.position);
        lineRenderer.SetPosition(1, playerMovement.FindJumpPoint());
        lineRenderer.SetPosition(2, playerMovement.target.transform.position);

        childObject.transform.position = playerMovement.FindJumpPoint();
    }
}
