using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogger_Movement : MonoBehaviour
{
    public int jumpsize;
    Vector3 startposition;
    void Start()
    {
        this.transform.position = new Vector3(0, 0.5f, 0);
        startposition = transform.position;

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + jumpsize);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - jumpsize);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + jumpsize, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - jumpsize, transform.position.y, transform.position.z);
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Water"))
        {
            transform.position = startposition;
        }
    }
}
