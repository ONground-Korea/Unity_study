using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float Timer = 0f;
    float interval = 1.6f;
    public GameObject luckyBox;  // ����� ���� ��

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // ����(��Ű�ڽ��̸�, ��ġ, ����)
        if (Timer >= interval)
        {
            // ���࿡ ���͹� ������ ���� 3�� �̻��� �Ǹ�
            // ��Ű�ڽ��� ����� ������Ʈ�� ����.
            transform.position = new Vector3(transform.position.x, Random.Range(-5, 6), 0); // y�� ���� -3 ~ 3���� �������� ����.
            Instantiate(luckyBox, transform.position, transform.rotation);
            Timer = 0f;
        }
        else Timer += Time.deltaTime;
    }
}
