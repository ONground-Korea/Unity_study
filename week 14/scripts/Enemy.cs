using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // ĳ���Ͱ� �꿡 ������ ���� �i�ƴٴϱ�

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
