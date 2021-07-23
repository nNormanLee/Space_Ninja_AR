using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownerPatrolUD : MonoBehaviour
{
    protected Vector3 velocity;
    public Transform _transform;
    public float distance = 1f;
    public float speed = 1f;
    Vector3 _originalPosition;
    public bool isGoingUp = false;
    public float distFromStart;

    public void Start()
    {
        _originalPosition = gameObject.transform.position;
        _transform = GetComponent<Transform>();
        velocity = new Vector3(0, speed, 0);
        _transform.Translate(0, velocity.y * Time.deltaTime, 0);
    }

    void Update()
    {
        distFromStart = transform.position.y - _originalPosition.y;

        if (isGoingUp)
        {
            // If gone too far, switch direction
            if (distFromStart < -distance)
                SwitchDirection();

            _transform.Translate(0, -velocity.y * Time.deltaTime, 0);
        }
        else
        {
            // If gone too far, switch direction
            if (distFromStart > distance)
                SwitchDirection();

            _transform.Translate(0, velocity.y * Time.deltaTime, 0);
        }
    }

    void SwitchDirection()
    {
        isGoingUp = !isGoingUp;
        //TODO: Change facing direction, animation, etc
    }
}
