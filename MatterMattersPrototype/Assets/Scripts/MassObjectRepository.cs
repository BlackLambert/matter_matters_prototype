using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassObjectRepository : MonoBehaviour
{
    private List<MassObject> massObjects = new List<MassObject>();

    public List<MassObject> MassObjectCopy { get { return new List<MassObject>(massObjects); } }

    public void Store(MassObject ojectToAdd)
    {
        massObjects.Add(ojectToAdd);
    }

    public void Remove(MassObject objectToRemove)
    {
        massObjects.Remove(objectToRemove);
    }
}
