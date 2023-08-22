using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    public float speed = 1.0f;

    private void Start()
    {
        this.rigid2D = gameObject.GetComponent<Rigidbody2D>();
        // AddForce
        // this.rigid2D.AddForce(transform.up * speed);
    }
    // Update is called once per fram
    void Update()
    {
        // tranform ÀÌµ¿
        transform.Translate(0, speed * Time.deltaTime, 0);

        if (transform.position.y > 6.0f)
        {
            Destroy(gameObject);
        }
    }
}
