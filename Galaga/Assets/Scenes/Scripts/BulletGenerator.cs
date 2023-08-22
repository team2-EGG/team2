using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{

    public GameObject Bulletprefab;
    public float span;
    float delta;

    void Start()
    {
        
    }

    
    void Update()
    {
        delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            delta = 0;

            Vector3 PP = this.transform.position;
            GameObject Bullet = Instantiate(Bulletprefab);
            Bullet.transform.position = PP + Vector3.left * 0.5f;
        }

    }
}
