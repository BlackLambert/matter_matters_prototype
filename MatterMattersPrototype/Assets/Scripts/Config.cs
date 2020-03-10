using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Config", menuName = "ScriptableObjects/Config")]
public class Config : ScriptableObject
{
    [SerializeField]
    private float _speedFactor = 0.001f;

    [SerializeField]
    private float _massDistanceOfEffectFactor = 1f;

    public float PlayerSpeedFactor { get { return _speedFactor;} }

    public float MassDistanceOfEffectFactor { get { return _massDistanceOfEffectFactor; } }
}
