using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public string nextSceneName;

    // Start is called before the first frame update
    Animator _anim;
    string status = "run";
    void Start()
    {
        _anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider any)
    {
        if (any.tag == "item_ball")
        {
            Destroy(any.gameObject);
        } else if(any.tag == "Enemy")
        {
            if(status == "run")
                SceneManager.LoadScene("Lose");
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _anim.speed = 1.5f;
            _anim.Play("JUMP00");
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            _anim.Play("DAMAGED01");
            status = "laying";

        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _anim.Play("DAMAGED01 0");
            status = "run";

        }
        if (GameObject.FindGameObjectsWithTag("item_ball").Length == 0)
        {
            // 다음 stage 으로 이동
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
