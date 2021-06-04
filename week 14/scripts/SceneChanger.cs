using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for Scene change

public class SceneChanger : MonoBehaviour
{
    public string nextSceneName;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit")) // joystick, keyboard, touch...
            SceneManager.LoadScene(nextSceneName);
    }
}
