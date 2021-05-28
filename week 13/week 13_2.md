# Week 13_2

## Contents

1. [3D캐릭터 구조](#1-3D캐릭터-구조)  
2. [Animation Retargeting](#2-Animation-Retargeting)
3. [Game 제작 준비 및 네비게이션 AI](#3-Game-제작-준비-및-네비게이션-AI)
4. [모션 처리](#4=모션-처리)

```
import

Standard Assets
Unity Chan Model
```

### 1. 3D캐릭터 구조  

**유니티 캐릭터 시스템 구성**  
- 애니메이션 파일
- 상태머신(status machine) 파일
- 아바타 파일
- 애니메이션 컨트롤러 파일

### 2. Animation Retargeting  

*다른 캐릭터의 애니메이션 기능을 이식해서 활용*  

-> component들을 복제

### 3. Game 제작 준비 및 네비게이션 AI

**적이 캐릭터를 따라다니도록 제작.**

캐릭터를 목적지로 사용  

map 제작
1) Nav Mesh Agent Component 추가

2) map으로 만들 오브젝트 Inspector에서 Navigation Static으로 변경

3) Navigation 뷰 열기

    ▪ Window – AI - Navigation 

4) ▪ Agent Radius : 통과 가능한 캐릭터의 넓이(몸통)

    ▪ Agent Height : 통과 가능한 캐릭터의 높이(키)
    
    ▪ Max Slope : 지나갈 수 있는 허용 경사도

    ▪ Step Height : 지나갈 수 있는 계단 허용 높이


캐릭터를 따라다니도록
```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject target; // destination
    NavMeshAgent myNavigation;

    // Start is called before the first frame update
    void Start()
    {
        myNavigation = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        myNavigation.destination = target.transform.position; 
    }
}
```

### 4. 모션 처리

프로젝트 뷰 – Create – [Animator Controller]

![](https://github.com/ONground-Korea/Unity_study/blob/main/week%2013/motion.png?raw=true)