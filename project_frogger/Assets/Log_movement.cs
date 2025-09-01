using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log_movement : MonoBehaviour
{
    [Header("LogSettings")]
    public Vector3 LogStartPosition;
    public Vector3 LogSlutPosition;
    public float LogSpeed;

   
    void Start()
    {
        transform.position = LogStartPosition;

        transform.DOMove(LogSlutPosition, LogSpeed).SetEase(Ease.Linear);


    }
}

