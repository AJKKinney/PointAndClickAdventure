using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//enables the player to toggle running
[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMoveSpeedController : MonoBehaviour
{
    public float walkSpeed = 3.5f;
    public float runSpeed = 5f;


    private NavMeshAgent navMeshAgent;
    private PlayerControls controls;

    void Start()
    {
        //initialize
        navMeshAgent = GetComponent<NavMeshAgent>();

        controls = new PlayerControls();
        controls.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //toggle run
        if (controls.PlayerActions.ToggleRun.WasPressedThisFrame())
        {
            if (navMeshAgent.speed == walkSpeed)
            {
                navMeshAgent.speed = runSpeed;
            }
            else
            {
                navMeshAgent.speed = walkSpeed;
            }
        }
    }
}
