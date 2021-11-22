using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float speed;
    void Start()
    {
        Destroy(gameObject,5f);
        rigidbody2D.AddRelativeForce(Vector2.up * speed,ForceMode2D.Impulse);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }
   

}
