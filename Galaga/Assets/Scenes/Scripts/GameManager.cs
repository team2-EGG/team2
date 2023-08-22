using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int BossHit = 0;
    GameObject GOboss;
    Boss boss;
    void Start()
    {
        GOboss = GameObject.FindWithTag("Boss");
    }

    void Clear()
    {
        Destroy(GOboss);
        //Å¬¸®¾î UI
    }

    // Update is called once per frame
    void Update()
    {
        if (BossHit > 20)
        {
            Bullet.pattern++;
        }
        if (BossHit > 40)
        {
            Bullet.pattern++;
        }
        if(BossHit > 60)
        {
            Bullet.pattern++;
        }
        if(BossHit > 80)
        {
            Bullet.pattern++;
        }
        if (BossHit == 100)
        {
            Clear();
        }
    }
}
