using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIHandler : MonoBehaviour
{

    public GameObject inventoryOverlay;
    private PlayerControls controls;
    private MouseRaycaster mouseRaycaster;
    private LayerMask playerLayer;


    void Start()
    {

        controls = new PlayerControls();
        controls.Enable();
        mouseRaycaster = GetComponent<MouseRaycaster>();
        playerLayer = LayerMask.NameToLayer("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //toggle inventory
        if (controls.PlayerActions.ToggleInventory.WasPressedThisFrame())
        {
            inventoryOverlay.SetActive(!inventoryOverlay.activeSelf);
        }

        //click character
        if (controls.PlayerActions.Select.WasPressedThisFrame())
        {
            RaycastHit hit = mouseRaycaster.RaycastFromMouse();

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.layer == playerLayer)
                {
                    inventoryOverlay.SetActive(!inventoryOverlay.activeSelf);
                }
            }
        }
    }
}
