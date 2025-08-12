using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Car_vroom : MonoBehaviour
{
    [Header("BilSettings")]
    public Vector3 bilstartposition;
    public Vector3 bilslutposition;
    public float bilspeed;

    [Header("Customize")]
    public List<Material> materials;
    public GameObject bilbase;
  void Start()
  {
    transform.position = bilstartposition;

    transform.DOMove(bilslutposition, bilspeed).SetEase(Ease.Linear);

    int randomColor = Random.Range(0, 3);
    bilbase.GetComponent<Renderer>().material = materials[randomColor];
    Debug.Log(randomColor + materials[randomColor].name);

  }

    void Update()
    {
        
    }
}
