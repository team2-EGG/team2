using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public int HP;                       
    private Enemy_Data enemyData;
    public const float moveSpeed = 2f;

    // Use this for initialization
    void Start () {
        enemyData = new Enemy_Data(HP);   
        Debug.Log(gameObject.name + "의 체력 : " + enemyData.getHP());
	}

    void Update()
    {
        moveControl();
        //프레임이 변화할때 마다 움직임을 관리해주는 함수를 호출해줍시다.
    }

    void moveControl()
    {
        float distanceY = moveSpeed * Time.deltaTime;
        //움직일 거리를 계산해줍니다.
        this.gameObject.transform.Translate(0, -1 * distanceY, 0);
        //움직임을 반영합니다.
    }

    void FixedUpdate()
    {
        if(enemyData.getHP() <= 0)
        {
            Debug.Log("파괴!!!!!");
            Destroy(gameObject);
            // 현재 적의 오브젝트를 메모리풀링으로 만들지 않았기 때문에
            // Destroy로 처리합니다.
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 부딛히는 collision을 가진 객체의 태그가 "Player Missile"일 경우
        if (collision.CompareTag("Player Missile"))
        {
            Debug.Log("미사일과 충돌");
            enemyData.decreaseHP(10);   // 체력을 10 감소
            Debug.Log(gameObject.name + "의 현재 체력 : " + enemyData.getHP());
        }
    }
}