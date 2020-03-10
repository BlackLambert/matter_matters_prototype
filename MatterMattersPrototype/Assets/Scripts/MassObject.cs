using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassObject : MonoBehaviour
{
    [SerializeField]
    protected Rigidbody2D _rigidbody2D;

    [SerializeField]
    protected Transform _base = null;

    [SerializeField]
    protected Config _config = null;

    [SerializeField]
    protected float _mass = 1;

    public float Mass { get { return _mass; } }

    public float MassDistanceOfEffect { get { return _rigidbody2D.mass * _config.MassDistanceOfEffectFactor; } }

    protected virtual void Start()
    {
        _rigidbody2D.mass = _mass;
    }

    public Vector2 DistanceTo(Transform otherObject)
    {
        Vector2 otherObjectPos = new Vector2(otherObject.position.x, otherObject.position.y);
        return _rigidbody2D.position - otherObjectPos;
    }
}
