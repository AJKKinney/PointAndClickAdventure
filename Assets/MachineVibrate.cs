using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//animates a vibrating GFX effect
public class MachineVibrate : MonoBehaviour
{
    public float intensity = 0.025f;

    private Vector3 startPos;
    

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = startPos + new Vector3(Random.Range(-intensity, intensity), Random.Range(-intensity, intensity), Random.Range(-intensity, intensity));
    }
}
