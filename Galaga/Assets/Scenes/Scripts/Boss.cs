using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    float time = 0;
    int direction = 1;
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0,0,Time.deltaTime * 10));
        

        


    }
}
