using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimationController : MonoBehaviour
{

    public Animator playerAnimator;

    private NavMeshAgent navMeshAgent;

    void Start()
    {
        //initialize
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        UpdateMoveSpeed(navMeshAgent.velocity.magnitude / navMeshAgent.speed);
    }

    public void UpdateMoveSpeed(float speed)
    {
        playerAnimator.SetFloat("MoveSpeed", speed);
    }

}
