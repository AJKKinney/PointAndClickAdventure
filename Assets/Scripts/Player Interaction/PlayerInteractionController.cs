using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This Class Controls Player Interaction with Interactables in the environment
[RequireComponent(typeof(PlayerNavMeshController))]
[RequireComponent(typeof(MouseRaycaster))]

public class PlayerInteractionController : MonoBehaviour
{
    private PlayerNavMeshController navController;
    private PlayerControls controls;
    private LayerMask interactionLayer;
    private MouseRaycaster mouseRaycaster;
    private Interactable focus;

    private readonly float stoppingDistance = 0.5f;

    void Start()
    {
        //initialize
        navController = GetComponent<PlayerNavMeshController>();

        controls = new PlayerControls();
        controls.Enable();

        interactionLayer = LayerMask.NameToLayer("Interaction");

        mouseRaycaster = GetComponent<MouseRaycaster>();
    }


    void Update()
    {
        if (controls.PlayerActions.Select.WasPressedThisFrame())
        {
            SetFocus();
        }

        if(focus != null)
        {
            if(Vector3.Distance(transform.position, focus.transform.position) <= stoppingDistance + focus.interactionRadius)
            {
                InteractWithFocus();
            }
        }
    }

    private void SetFocus()
    {
        mouseRaycaster.RaycastFromMouse(out RaycastHit hit);

        //check for interactable
        if (hit.collider != null)
        {
            if (hit.collider.gameObject.layer == interactionLayer)
            {
                focus = hit.collider.GetComponent<Interactable>();

                //move to interactable
                if (Vector3.Distance(transform.position, hit.transform.position) > stoppingDistance + focus.interactionRadius)
                {
                    navController.MoveToLocation(hit.point);
                }

                Debug.Log("Set Focus to " + focus.gameObject.name);
            }
            else
            {
                //clear focus
                focus = null;
                Debug.Log("Cleared Focus");
            }
        }
    }

    private void InteractWithFocus()
    {
        focus.Interact();
        navController.MoveToLocation(transform.position);
        focus = null;
        Debug.Log("Cleared Focus");
    }
}
