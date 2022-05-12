using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//rotates the lamp correctly
public class LampAnimator : MonoBehaviour
{

    private Quaternion startRotation;

    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = startRotation;
    }
}
