using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class drawline : MonoBehaviour {
    public NavMeshAgent ag;
    public LineRenderer line;
    // Use this for initialization
    void Start () {
        line = GetComponent<LineRenderer>();
       
    }
	
	// Update is called once per frame
	void Update () {
        if (ag.hasPath)
        {
            line.positionCount=ag.path.corners.Length;
            line.SetPositions(ag.path.corners);
            line.enabled = true;
        }else
        {
            line.enabled = false;

        }
	}
}
