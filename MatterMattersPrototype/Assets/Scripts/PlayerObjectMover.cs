﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjectMover : MonoBehaviour
{
    [SerializeField]
    private Transform _base = null;

    [SerializeField]
    private float _speed = 1f;

    [SerializeField]
    private Config _config = null;

    [SerializeField]
    private Rigidbody2D _rigidbody = null;

    protected virtual void Start()
    {

    }

    protected virtual void FixedUpdate()
    {
        if(Input.GetMouseButton(0))
        {
            setVelocity();
        }
    }

    private Vector2 calculateMouseDistance()
    {
        Vector2 position = Camera.main.WorldToScreenPoint(_base.position);
        Vector2 mousePosition = Input.mousePosition;

        return mousePosition - position;
    }

    private void setVelocity()
    {
        Vector2 mouseDistance = calculateMouseDistance();
        _rigidbody.velocity = calculateSpeed(mouseDistance) * mouseDistance.normalized;
    }

    private float calculateSpeed(Vector2 distance)
    {
        return distance.magnitude * _speed * _config.PlayerSpeedFactor;
    }
}
