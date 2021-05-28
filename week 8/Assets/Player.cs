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

    private void OnCollisionEnter(Collision any) // 콜리전에 충돌하면
    {
        // 처음부터 게임을 다시 시작할 것임. (같은 씬을 다시 로드) SceneManager.LoadScene("Main");
        // 충돌이 되면 소리 들리게
        // 충돌이 되면 화면에 게임 오버 표시
        GameOverBox.SetActive(true); // GameOverBox 안에 있는 객체를 active상태로 돌림.
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // 멀티 플랫폼이면 GetButtonDown("Fire1") 등 정의된 버튼 사용 가능.

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) // space 또는 마우스 왼쪽을 눌렀을 때 Player가 위쪽으로 점프
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
        if (Input.GetButtonDown("Fire2")) // L_alt, 마우스 오른쪽
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);

        // 충돌 체크
        
    }
}
