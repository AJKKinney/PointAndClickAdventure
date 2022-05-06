using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Interactable Base Class
[RequireComponent(typeof(Collider))]

public class Interactable : MonoBehaviour
{
    [Header("Interaction Settings")]
    public float interactionRadius = 1f;


    public virtual void Interact()
    {
        Debug.Log("The player interacted with " + gameObject.name);
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, interactionRadius);
    }
}
