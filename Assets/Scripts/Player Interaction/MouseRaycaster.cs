using UnityEngine;
using UnityEngine.EventSystems;

public class MouseRaycaster : MonoBehaviour
{
    private Camera cam;
    private PlayerControls controls;

    private readonly float raycastDistance = 50f;

    void Awake()
    {
        //initialize
        cam = Camera.main;
        controls = new PlayerControls();
        controls.Enable();
    }


    public RaycastHit RaycastFromMouse()
    {
        //move to location
        Ray ray = cam.ScreenPointToRay(controls.PlayerActions.MousePosition.ReadValue<Vector2>());

        //check for ground
        Physics.Raycast(ray, out RaycastHit hit, raycastDistance);

        //block with UI
        if (EventSystem.current.IsPointerOverGameObject() == true)
        {
            hit = new RaycastHit();
        }

        return hit;
    }

    public void RaycastFromMouse(out RaycastHit hit)
    {
        //move to location
        Ray ray = cam.ScreenPointToRay(controls.PlayerActions.MousePosition.ReadValue<Vector2>());

        //check for ground
        Physics.Raycast(ray, out hit, raycastDistance);
    }
}
