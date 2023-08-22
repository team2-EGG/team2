using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    public GameObject Bullet; // �Ѿ�
    public float moveForce = 25.0f; // �����̴� ��
    Vector3 pos; // ����� ���� ��ġ


    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        this.pos = this.gameObject.transform.position; // ����� ���� ��ġ

        // ȭ�� �ۿ� ������ �����ʰ� �ϱ�, ���� �ö󰡸� �ٽ� �Ʒ����� ����, �Ʒ��� �������� ������ ����
        if (this.pos.x > 11.0f)
        {
            this.gameObject.transform.position = new Vector3(11.0f, pos.y, pos.z);

        }
        if (this.pos.x < -11.0f)
        {
            this.gameObject.transform.position = new Vector3(-11.0f, pos.y, pos.z);
        }


        // ����� ����
        /*if (Input.GetKey(KeyCode.LeftArrow)) // �������� �̵�
        {
            this.rigid2D.AddForce(transform.right * -moveForce * Time.deltaTime * 80);
        }
        if (Input.GetKey(KeyCode.RightArrow)) // ���������� �̵�
        {
            this.rigid2D.AddForce(transform.right * moveForce * Time.deltaTime * 80);
        }
        if (Input.GetKeyDown(KeyCode.Space)) // �� �߻�
        {
            GameObject fire = Instantiate(Bullet);
            this.pos.x += 1.3f;
            fire.transform.position = this.pos;
        }*/

        // ����� ����
        if (Input.GetKey(KeyCode.LeftArrow)) // �������� �̵�
        {
            transform.Translate(Vector2.left * moveForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)) // ���������� �̵�
        {
            transform.Translate(Vector2.right * moveForce * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space)) // �� �߻�
        {
            GameObject fire = Instantiate(Bullet);
            this.pos.y += 0.8f;
            fire.transform.position = this.pos;
        }
    }
}
