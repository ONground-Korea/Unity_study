# Week 14_2

## Contents


## 1. Scene changing  

<br>
새로운 Scene 생성  

`nextSceneName := Scene`

```c#
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
```

### 1.1 Apply new Scenes

File - Build Settings - Scenes in Build 에 제작된 Scenes를 모두 추가

### 1.2 Scripts

[Scripts](https://github.com/ONground-Korea/Unity_study/tree/main/week%2014/scripts)
