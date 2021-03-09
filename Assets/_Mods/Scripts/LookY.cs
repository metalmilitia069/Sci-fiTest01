using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour
{

    private float _mouseY;
    [SerializeField]
    private float _mouseSensitivity = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _mouseY = Input.GetAxis("Mouse Y");

        Vector3 newRotation = transform.localEulerAngles;
        newRotation.x += (_mouseY * _mouseSensitivity);
        transform.localEulerAngles = newRotation;
    }
}
