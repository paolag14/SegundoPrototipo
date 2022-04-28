using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBackground : MonoBehaviour {

    private Transform cameraTransform;
    private Vector3 lastCameraPos;

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPos = cameraTransform.position;
        
    }

    void LateUpdate(){
        Vector3 deltaMovement = cameraTransform.position - lastCameraPos;
        float parallaxEffectMultiplier = 0.5f;
        transform.position += deltaMovement * parallaxEffectMultiplier;
        lastCameraPos = cameraTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
