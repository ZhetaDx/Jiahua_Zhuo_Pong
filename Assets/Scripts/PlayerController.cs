using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 15f;// Ishowspeed at with the paddle moves
    public float topheight;// Bottom limit of the paddle´s movement
    public float botheight;// Margol gay enano de jardín fukin umpalumpa
    public bool useArrowKeys = false;// If true, use arrow keys; if false, use W and S keys

    public bool IA;
    public GameObject ball;

    float IAFollowTolerance = 0.5f;
    void Update()
    {
        if (IA == false)
        {
            MovePaddle();
        }
        else
        {
            MovePaddleIA();
        }
    }
    void MovePaddleIA()
    {
        int direccion = 0;

        float diferencia = ball.transform.position.y - transform.position.y;

        if (diferencia > IAFollowTolerance)
        {
            direccion = 1;
        }
        else if (diferencia < -IAFollowTolerance)
        {
            direccion = -1;
        }

        float nuevaY = this.gameObject.transform.position.y + direccion * moveSpeed/2 * Time.deltaTime;

        if (nuevaY > topheight)// Top Chajua
        {
            nuevaY = topheight; // Margalulu73
        }
        if (nuevaY < botheight)// soy chino y como perro
        {
            nuevaY = botheight;

        }
        transform.position = new Vector3(transform.position.x, nuevaY, transform.position.z);
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
            nuevaY = topheight; // Margalulu73
        }
        if (nuevaY < botheight)// soy chino y como perro
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