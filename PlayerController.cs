using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    public GameObject Bullet; // 총알
    public float moveForce = 25.0f; // 움직이는 힘
    Vector3 pos; // 비행기 현재 위치


    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        this.pos = this.gameObject.transform.position; // 비행기 현재 위치

        // 화면 밖에 나가게 하지않게 하기, 위로 올라가면 다시 아래에서 나옴, 아래로 내려가면 위에서 나옴
        if (this.pos.x > 11.0f)
        {
            this.gameObject.transform.position = new Vector3(11.0f, pos.y, pos.z);

        }
        if (this.pos.x < -11.0f)
        {
            this.gameObject.transform.position = new Vector3(-11.0f, pos.y, pos.z);
        }


        // 비행기 조작
        /*if (Input.GetKey(KeyCode.LeftArrow)) // 왼쪽으로 이동
        {
            this.rigid2D.AddForce(transform.right * -moveForce * Time.deltaTime * 80);
        }
        if (Input.GetKey(KeyCode.RightArrow)) // 오른쪽으로 이동
        {
            this.rigid2D.AddForce(transform.right * moveForce * Time.deltaTime * 80);
        }
        if (Input.GetKeyDown(KeyCode.Space)) // 총 발사
        {
            GameObject fire = Instantiate(Bullet);
            this.pos.x += 1.3f;
            fire.transform.position = this.pos;
        }*/

        // 비행기 조작
        if (Input.GetKey(KeyCode.LeftArrow)) // 왼쪽으로 이동
        {
            transform.Translate(Vector2.left * moveForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)) // 오른쪽으로 이동
        {
            transform.Translate(Vector2.right * moveForce * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space)) // 총 발사
        {
            GameObject fire = Instantiate(Bullet);
            this.pos.y += 0.8f;
            fire.transform.position = this.pos;
        }
    }
}
