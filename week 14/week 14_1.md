# Week 14_1

## Contents

## 1. Animation

Animation  재생 -> `Play()`함수 사용  

```c#
public class Player : MonoBehaviour
{
    Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _anim.speed = 2.0f;
            _anim.Play("JUMP00");
        }
    }
}
```
사용할 애니메이션을 Animator창에 넣고, 기준 애니메이션과 연결시킨다.

## 2. Charactor, Animation change

fbx 파일에서 
```
Rig -> Animation Type = humanoid로 설정
configure -> Enforce T pose설정

Materials -> Extract Textures (같은 폴더에)
          -> Extract Materials (같은 폴더에)

Animation -> Loop Time 체크
```
로 설정 후, fbx파일을 Scene에 배치.

캐릭터의 Animator -> Controller 설정 (자신이 만들어 놓은 Animator Controller 혹은 Standard Assets의 ThirdPersonAnimatorController을 변경하여 사용하면 된다.)

### 2.1 특정 애니메이션만 변경

ThirdPersonAnimatorController에서 달리기 애니메이션만 다른 것으로 변경하려는 경우 :

`Animator -> Ground 더블클릭 -> 달리기 Motion 을 다른 것으로 변경`

![]()