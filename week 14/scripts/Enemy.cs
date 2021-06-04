using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // 캐릭터가 펫에 가까이 오면 쫒아다니기

    public GameObject target;
    NavMeshAgent myNavgation;
    // Start is called before the first frame update
    void Start()
    {
        myNavgation = GetComponent<NavMeshAgent>();
    }


    // Update is called once per frame
    void Update()
    {

            myNavgation.destination = target.transform.position;

    }
}
