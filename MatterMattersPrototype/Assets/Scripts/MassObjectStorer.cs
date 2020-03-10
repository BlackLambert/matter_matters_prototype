using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassObjectStorer : MonoBehaviour
{
    [SerializeField]
    private MassObject _massObject = null;



    private MassObjectRepository _repository; 

    protected virtual void Start()
    {
        _repository = GameObject.FindObjectOfType<MassObjectRepository>();
        _repository.Store(_massObject);
    }

    protected virtual void OnDestroy()
    {
        if(_repository != null)
        {
            _repository.Remove(_massObject);
        }
    }
}
