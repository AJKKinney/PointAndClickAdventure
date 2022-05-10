using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIHandler : MonoBehaviour
{

    public GameObject inventoryOverlay;
    private PlayerControls controls;

    void Start()
    {

        controls = new PlayerControls();
        controls.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //toggle run
        if (controls.PlayerActions.ToggleInventory.WasPressedThisFrame())
        {
            inventoryOverlay.SetActive(!inventoryOverlay.activeSelf);
        }
    }
}
