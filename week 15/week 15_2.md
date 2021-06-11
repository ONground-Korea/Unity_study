
```
import
Mega Fantasy Props Pack
Standard Assets
```

## 1. Interactive Animation

### Interactive door / box

Window - Animation - Animation 에서 원하는 상태 녹화

![]()

door Animator에 변수를 생성함으로써 Animator를 제어 가능.

![]()

Transition 2개 생성
```
doorClose -> doorOpen (if isTouch = True)
doorOpen -> doorClose (is isTouch = False)
```

![]()

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

![]() gif

