using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionFollower : MonoBehaviour
{
    [SerializeField]
    private Transform _objectToFollow = null;

    [SerializeField]
    private Transform _base = null;

    protected virtual void Update()
    {
        Vector3 pos = _objectToFollow.position;
        _base.position = new Vector3(pos.x, pos.y, _base.position.z);
    }
}
