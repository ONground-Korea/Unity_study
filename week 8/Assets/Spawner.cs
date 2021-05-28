using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float Timer = 0f;
    float interval = 1.6f;
    public GameObject luckyBox;  // 만들어 놓은 벽

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // 스폰(럭키박스이름, 위치, 각도)
        if (Timer >= interval)
        {
            // 만약에 인터벌 변수의 값이 3초 이상이 되면
            // 럭키박스에 담겨진 오브젝트를 스폰.
            transform.position = new Vector3(transform.position.x, Random.Range(-5, 6), 0); // y축 값을 -3 ~ 3까지 랜덤으로 변경.
            Instantiate(luckyBox, transform.position, transform.rotation);
            Timer = 0f;
        }
        else Timer += Time.deltaTime;
    }
}
