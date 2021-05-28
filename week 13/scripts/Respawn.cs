using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    static int score; // score �������� ���� ������ ��� ����

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("scoreSave", 0); // ó�� ����� �ʱ�ȭ(������Ʈ���� ���� 0���� �ʱ�ȭ)
    }
    private void OnTriggerEnter(Collider other)
    {
        this.GetComponent<MeshCollider>().enabled = false;
        this.GetComponent<MeshRenderer>().enabled = false;
        score++;
        PlayerPrefs.SetInt("scoreSave", score);
        Invoke("Regen", 5);
    }
    void Regen()
    {
        this.GetComponent<MeshCollider>().enabled = true;
        this.GetComponent<MeshRenderer>().enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
