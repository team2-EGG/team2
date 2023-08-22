using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;
    Rigidbody2D rb;
    public static int pattern = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = this.GetComponent<Rigidbody2D>();

        rb.AddForce(Vector2.left * 25 * speed);
    }

    void pattern3()
    {
        if (this.transform.position.x < 0)
        {
            rb.AddForce(Vector2.up * Random.Range(-25, 25));
        }
    }

    void pattern4()
    {
        if (this.transform.position.x < 3 && this.transform.position.x > 2.9)
        {
            rb.AddForce(Vector2.up * Random.Range(-25, 25));
        }

        if (this.transform.position.x < 0 && this.transform.position.x > -0.1)
        {
            rb.AddForce(Vector2.up * Random.Range(-25, 25));
        }

        if (this.transform.position.x < -3 && this.transform.position.x > -3.1)
        {
            rb.AddForce(Vector2.up * Random.Range(-20, 25));
        }
    }

    void pattern2()
    {
        if (this.transform.position.x < 0 && this.transform.position.x > -0.1)
        {
            rb.AddForce(Vector2.left * Random.Range(-25, 25));
        }
    }

    void pattern1()
    {
        if (this.transform.position.x < 0 && this.transform.position.x > -0.1)
        {
            rb.AddForce(Vector2.left * 25);
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (pattern)
        {
            case 0:
                break;
            case 1:
                pattern1();
                break;
            case 2:
                pattern2();
                break;
            case 3:
                pattern3();
                break;
            case 4:
                pattern4();
                break;
            default: break;
        }
        


        if (this.transform.position.x < -30)
        {
            Destroy(gameObject);
        }

        
    }

    

}
