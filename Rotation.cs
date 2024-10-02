using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float torqueAmount = 10f;
    void Start()
    {
        GetComponent<Rigidbody2D>().AddTorque(torqueAmount);
    }

    void Update()
    {
        
    }
}