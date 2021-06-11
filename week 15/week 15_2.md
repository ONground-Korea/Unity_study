
```
import
Mega Fantasy Props Pack
Standard Assets
```

## 1. Interactive Animation

### Interactive door / box

Window - Animation - Animation 에서 원하는 상태 녹화

![](https://github.com/ONground-Korea/Unity_study/blob/main/week%2015/pictures/%ED%99%94%EB%A9%B4%20%EC%BA%A1%EC%B2%98%202021-06-11%20172455.png?raw=true)

door Animator에 변수를 생성함으로써 Animator를 제어 가능.

![](https://github.com/ONground-Korea/Unity_study/blob/main/week%2015/pictures/%ED%99%94%EB%A9%B4%20%EC%BA%A1%EC%B2%98%202021-06-11%20173130.png?raw=true)

Transition 2개 생성
```
doorClose -> doorOpen (if isTouch = True)
doorOpen -> doorClose (is isTouch = False)
```

![](https://github.com/ONground-Korea/Unity_study/blob/main/week%2015/pictures/%ED%99%94%EB%A9%B4%20%EC%BA%A1%EC%B2%98%202021-06-11%20173711.png?raw=true)

Door에 Box Collider(isTrigger), script 추가
onTrigger 이면 door을 열고, 아니면 닫는다.
```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    Animator _anim; // for getting Animator

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        _anim.SetBool("isTouch", true); // (Animator Controller -> isTouch) := True
    }
    private void OnTriggerExit(Collider other) // if trigger exit
    {
        _anim.SetBool("isTouch", false); // (Animator Controller -> isTouch) := False
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
```

**같은 방식으로 box도 Animation 설정**

![](https://github.com/ONground-Korea/Unity_study/blob/main/week%2015/pictures/%ED%99%94%EB%A9%B4%20%EC%BA%A1%EC%B2%98%202021-06-11%20175135.png?raw=true)

![](https://github.com/ONground-Korea/Unity_study/blob/main/week%2015/pictures/(%EB%85%B9%ED%99%94)%20%EC%9D%B4%EB%A6%84%20-%202021.06.11%2018_30_50.gif?raw=true)

