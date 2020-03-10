using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableMassObject : MassObject
{
    private Vector2 Velocity { set { _rigidbody2D.velocity = value; } }

    private MassObjectRepository _repository;

    protected override void Start()
    {
        base.Start();
        _repository = GameObject.FindObjectOfType<MassObjectRepository>();
    } 

    protected virtual void FixedUpdate()
    {
        List<MassObject> massObjects = _repository.MassObjectCopy;

        Vector2 endVelocity = Vector2.zero;

        foreach(MassObject mo in massObjects)
        {
            if(mo == this)
            {
                continue;
            }

            Vector2 distanceTo = mo.DistanceTo(_base);

            if (distanceTo.magnitude > mo.MassDistanceOfEffect)
            {
                continue;
            }

            float distanceProportion = 1 - distanceTo.magnitude / mo.MassDistanceOfEffect;

            Vector2 speedProportion = distanceTo.normalized * (mo.Mass / Mass);


            endVelocity += distanceProportion * speedProportion * 0.8f;
        }

        Velocity = endVelocity;
    }
}
