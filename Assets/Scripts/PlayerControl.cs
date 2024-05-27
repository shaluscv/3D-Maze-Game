using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float rotateSpeed;
    public float maxRotation;
    public float mouseX, mouseY;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetMouseButton(0)) { 
            RotateMaze();
        }
    }

    private void RotateMaze()
    {
        mouseX += Input.GetAxis("Mouse X");
        mouseY += Input.GetAxis("Mouse Y");
        float rotateX = mouseX * rotateSpeed;
        float rotateY = mouseY * rotateSpeed;

        rotateX = Mathf.Clamp(rotateX, -maxRotation, maxRotation);
        rotateY = Mathf.Clamp(rotateY, -maxRotation, maxRotation);

        transform.eulerAngles = new Vector3(rotateY, transform.rotation.y, -rotateX); 



    }


}
