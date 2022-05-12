using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimationController : MonoBehaviour
{

    public Animator playerAnimator;

    private NavMeshAgent navMeshAgent;
    private float maxSpeed;

    void Start()
    {
        //initialize
        navMeshAgent = GetComponent<NavMeshAgent>();
        maxSpeed = navMeshAgent.speed;
    }

    void Update()
    {
        UpdateMoveSpeed(navMeshAgent.velocity.magnitude / maxSpeed);
    }

    public void UpdateMoveSpeed(float speed)
    {
        playerAnimator.SetFloat("MoveSpeed", speed);
    }

}
