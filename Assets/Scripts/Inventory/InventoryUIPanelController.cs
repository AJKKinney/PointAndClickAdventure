using UnityEngine;
using Cinemachine;

public class InventoryUIPanelController : MonoBehaviour
{

    public CinemachineFreeLook vCam;

    private Vector2 startPos;
    private RectTransform rect;

    private readonly float scrollRange = 40f;  

    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        startPos = rect.anchoredPosition;
    }


    private void Update()
    {
        SetHeight(vCam.m_YAxis.Value);
    }


    public void SetHeight(float value)
    {
        rect.anchoredPosition = new Vector2(startPos.x, startPos.y + (scrollRange * value));
    }
}
