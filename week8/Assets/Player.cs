using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int jumpPower = 5;
    public GameObject GameOverBox;
    public GameObject GameStartBox;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(GameStartBox, 2);
    }

    private void OnCollisionEnter(Collision any) // �ݸ����� �浹�ϸ�
    {
        // ó������ ������ �ٽ� ������ ����. (���� ���� �ٽ� �ε�) SceneManager.LoadScene("Main");
        // �浹�� �Ǹ� �Ҹ� �鸮��
        // �浹�� �Ǹ� ȭ�鿡 ���� ���� ǥ��
        GameOverBox.SetActive(true); // GameOverBox �ȿ� �ִ� ��ü�� active���·� ����.
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // ��Ƽ �÷����̸� GetButtonDown("Fire1") �� ���ǵ� ��ư ��� ����.

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) // space �Ǵ� ���콺 ������ ������ �� Player�� �������� ����
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
        if (Input.GetButtonDown("Fire2")) // L_alt, ���콺 ������
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);

        // �浹 üũ
        
    }
}
