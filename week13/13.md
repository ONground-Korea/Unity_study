# Week 13

## 1. Audio
## 2. 3D Sound

```
import 

`Retro Games Sound FX`
`sound.unitypackage`
```

## 1. Audio

Audio Listener 은 한 곳에만 존재해야 한다. 
-> main camera 와 미니맵 camera의 audio listener 체크 해제 후 캐릭터에 추가.

Ball

`rigid body`

`physic material`

`audio source : sound 출력 (audio clip에서)`

### 공이 바닥과 충돌했을 때 sound 출력
Ball

`SndPlay script 생성`
```c#
private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
    }
```


### 캐릭터가 물체와 부딪혔을 때 각각 다른 소리가 나도록

sound를 그룹화 하여 (바위, 나무, 집 등)과 부딪혔을 때 나오는 소리 등으로 만듦. 
-> Tag 사용. 

`PlayOneShot( , )` 함수 사용. 
```
여러 audio clip 사용 가능
볼륨 설정 가능
```

```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SndPlay : MonoBehaviour
{
    public AudioClip SndTree;
    public AudioClip SndRock;
    public AudioClip SndHouse;
    public AudioClip SndPlane;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision Detected)
    {
        if (Detected.gameObject.tag == "House")
        {
            GetComponent<AudioSource>().PlayOneShot(SndHouse, 1f);
        }
        else if (Detected.gameObject.tag == "Plane")
        {
            GetComponent<AudioSource>().PlayOneShot(SndPlane, 1f);
        }
        else if (Detected.gameObject.tag == "Tree")
        {
            GetComponent<AudioSource>().PlayOneShot(SndTree, 1f);
        }
        else if (Detected.gameObject.tag == "바위")
        {
            GetComponent<AudioSource>().PlayOneShot(SndRock, 1f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

```

### 아이템 획득 시 사운드 처리

Destroy 처리

`Destroy (this.gameObject, 1.5f); // 1.5초 뒤 소멸처리`
`myAudio.clip.length : 오디오 클립의 재생시간 자동지정`
> 자동지정일 경우, 사운드의 무음처리 구간까지 반영됨(무음 확인)
```c#
public class SoundPlay : MonoBehaviour 
{
    AudioSource _myAudio;
    void Start () 
    {   
        _myAudio = GetComponent<AudioSource> ();
    }

    void OnTriggerEnter(Collider hit) // Collider 주의
    {
        _myAudio.Play ();
        Destroy (this.gameObject, _myAudio.clip.length);
    }
}
```

### 총알 발사 버튼이 눌러지면 소리 출력하기

```c#
public class Player : MonoBehaviour 
{
    public AudioClip _SoundGun;
    void Update () 
    {
        if (Input.GetButtonDown("Fire1"))
            GetComponent<AudioSource>().PlayOneShot(_SoundGun, 
    }
}
```

## 2. 3D Sound

Audio Source -> Spartial Blend 를 3D로 변경

거리에 따라서 소리의 크기 변경 가능