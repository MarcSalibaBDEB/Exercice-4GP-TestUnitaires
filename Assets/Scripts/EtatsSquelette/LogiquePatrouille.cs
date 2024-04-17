using Codice.Client.BaseCommands;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LogiquePatrouille
{
    public Transform[] _points;
    private int _indexPatrouille;

    public Vector3 PointCourant
    {
        get
        {
            return _points[_indexPatrouille].position;
        }
    }

    public LogiquePatrouille(Transform[] points)
    {
        _points = points;
        _indexPatrouille = 0;
    }

    public void ChangerDePoints()
    {
        _indexPatrouille = (_indexPatrouille + 1) % _points.Length;
    }


}
