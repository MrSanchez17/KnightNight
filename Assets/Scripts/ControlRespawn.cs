using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRespawn : MonoBehaviour
{

    public GameObject objectiveRespawn;
    public GameObject objectMove;
        
    public void MoveSapwn()
    {
        Vector3 newposition = objectiveRespawn.transform.position ;
        objectMove.transform.position = newposition;
    }
}
