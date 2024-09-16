using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newva : MonoBehaviour
{
    [SerializeField] float xValue = 0;
    [SerializeField] float yValue = 0.02f;
    [SerializeField] float zValue = 0;

   void Start()
    {
       
    }

    void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}
