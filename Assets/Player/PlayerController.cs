using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float speed;
    public float bulletSpeed;
    public GameObject bulletPrefab;
    public Transform shootingPoint;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody2D.AddRelativeForce(Vector2.up * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody2D.AddRelativeForce(Vector2.down * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.AddRelativeForce(Vector2.left * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.AddRelativeForce(Vector2.right * speed);
        }
        if (Input.GetMouseButton(0))
        {
         GameObject bullet=   Instantiate(bulletPrefab, transform.position, transform.rotation);
            Bullet bulletCode = bullet.GetComponent<Bullet>();
            bulletCode.speed = bulletSpeed;

        }
    }
}
