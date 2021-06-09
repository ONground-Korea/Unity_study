# Week 15_1

```
import Low Poly Brick Houses
import StandardAssets -> Characters, CorssPlatforms, Utility
```

## Contents

1. [Animation Tool](#1-Animation-Tool)

## 1. Animation Tool

`메뉴 - Window - Animation - Animation`
- GameObject의 위치, 각도, 스케일 등을 타임라인으로 조정
- 컴포넌트 속성 (재질 색상, 라이트 강도, 사운드 볼륨 등)
- Curves처리를 통해 부드러운 애니메이션 적용.

</br>

### 1.1 인트로 애니메이션 

1. Camera Object를 선택 후 녹화 시작
![](https://github.com/ONground-Korea/Unity_study/blob/main/week%2015/pictures/%ED%99%94%EB%A9%B4%20%EC%BA%A1%EC%B2%98%202021-06-09%20173836.png?raw=true)
3. 원하는 카메라 포지션(뷰)에서 `ctrl + shift + f`
4. 녹화 중단
     - intro 동영상이 무한 반복되지 않게 하려면 Loop Time 체크 해제

![](https://github.com/ONground-Korea/Unity_study/blob/main/week%2015/pictures/%ED%99%94%EB%A9%B4%20%EC%BA%A1%EC%B2%98%202021-06-09%20175027.png?raw=true)
5. Curves를 사용하여 미세 조정
6. 인트로 영상에서 아무 키나 눌렀을 때 Main Scene으로 이동
```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for Scene change

public class GotoMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
            SceneManager.LoadScene("Main");
    }
}
```
![영상](https://github.com/ONground-Korea/Unity_study/blob/main/week%2015/pictures/intro.gif?raw=true)
