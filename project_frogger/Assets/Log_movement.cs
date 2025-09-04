using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log_movement : MonoBehaviour
{
    public void Move(float LogSpeed,Vector3 startpos, Vector3 slutpos)
    {
        transform.localPosition = startpos;
        transform.DOLocalMove(slutpos, LogSpeed).SetEase(Ease.Linear);

    }
}

