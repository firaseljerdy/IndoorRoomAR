using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AI;

public class SetNavigationTarget : MonoBehaviour
{

    [SerializeField]
    private Camera topDownCamera;
    [SerializeField]
    private GameObject navTargetObject;

    private NavMeshPath path;
    private LineRenderer line;

    private bool lineToggle = true;

    void Start()
    {
        path = new NavMeshPath();
        line = transform.GetComponent<LineRenderer>();
    }

    void Update()
    {
        NavMesh.CalculatePath(transform.position, navTargetObject.transform.position, NavMesh.AllAreas, path);
        line.positionCount = path.corners.Length;
        line.SetPositions(path.corners);
        line.enabled = true;
    }
}
