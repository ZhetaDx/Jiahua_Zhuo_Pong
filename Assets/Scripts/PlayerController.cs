using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 15f;// Ishowspeed at with the paddle moves
    public float topheight;// Bottom limit of the paddle´s movement
    public float botheight;// Margol gay enano de jardín fukin umpalumpa
    public bool useArrowKeys = false;// If true, use arrow keys; if false, use W and S keys

    void Update()
    {
        MovePaddle();
    }

    void MovePaddle()
    {
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, ConstraintPaddle(), this.gameObject.transform.position.z);
    }

    float ConstraintPaddle()
    {
        float nuevaY = this.gameObject.transform.position.y + (PaddleDirection() * moveSpeed * Time.deltaTime);

        if (nuevaY > topheight)// Top Chajua
        {
            nuevaY = topheight;
        }
        if (nuevaY < botheight)// Bottom Margol
        {
            nuevaY = botheight;
        }
        return nuevaY;
    }

    float PaddleDirection()
    {
        float direccion = 0f;
        if (useArrowKeys == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                direccion = 1f;

            }
            if (Input.GetKey(KeyCode.DownArrow))// (down=margol)
            {
                direccion = -1f;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W))// W Speed
            {
                direccion = 1f;
            }
            if (Input.GetKey(KeyCode.S))// Say Wallahi bro
            {
                direccion = -1f;
            }
        }
        return direccion;
    }
}