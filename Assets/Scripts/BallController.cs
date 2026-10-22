using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{
    public float velocidad = 10f;
    public GameManager GameManager;
    private Rigidbody2D _rb;
    public Collider2D Collider;
    void Start()
    {   

        _rb = this.gameObject.GetComponent<Rigidbody2D>();
        LaunchBall();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_rb.velocity.magnitude > velocidad)
        {
            _rb.velocity = _rb.velocity.normalized * velocidad;
        }
    }
    void LaunchBall()
    {
        bool isRight = false;
        if (Random.value > 0.5f)
    {
            isRight = true;
        }

        float xVelocity = -1;
        if (isRight == true)
        {
            xVelocity = 1;
        }
        float yVelocity = Random.Range(-1f, 1f);
        _rb.velocity = new Vector2(xVelocity * velocidad, yVelocity * velocidad);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("BallHit");
        GameManager.PuntosP1++;
        GameManager.PuntosP2++;
        GameManager.UpdatePointsText();

    }
}

