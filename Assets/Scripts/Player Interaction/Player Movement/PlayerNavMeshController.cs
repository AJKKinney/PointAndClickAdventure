using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;


//This Class Controls Player Movement Input
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(MouseRaycaster))]

public class PlayerNavMeshController : MonoBehaviour
{

    private NavMeshAgent navMeshAgent;
    private PlayerControls controls;
    private LayerMask groundLayer;
    private MouseRaycaster mouseRaycaster;

    void Start()
    {
        //initialize
        navMeshAgent = GetComponent<NavMeshAgent>();

        controls = new PlayerControls();
        controls.Enable();

        groundLayer = LayerMask.NameToLayer("Ground");

        mouseRaycaster = GetComponent<MouseRaycaster>();
    }


    void Update()
    {
        //set destination
        if(controls.PlayerActions.Select.WasPressedThisFrame())
        {
            RaycastHit hit = mouseRaycaster.RaycastFromMouse();

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.layer == groundLayer)
                {
                    MoveToLocation(hit.point);
                }
            }
        }
    }



    //moves the destination to the input position
    public void MoveToLocation(Vector3 position)
    {
        //set destination
        navMeshAgent.destination = position;
    }
}
