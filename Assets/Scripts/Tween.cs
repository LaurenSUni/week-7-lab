using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween
{

    //following properties should be publicallly accessible but can only be set privately
    public Transform Target { get; private set; }
    public Vector3 StartPos { get; private set; }
    public Vector3 EndPos { get; private set; }
    public float StartTime { get; private set; }
    public float Duration { get; private set; }
}
