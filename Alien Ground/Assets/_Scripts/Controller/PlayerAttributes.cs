using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    [Header("RawDatas")]
    
    public bool upwardThrust;
    public float linearThrust;

    [Header("Mover")]
    public float goalRotational=10f;
}
