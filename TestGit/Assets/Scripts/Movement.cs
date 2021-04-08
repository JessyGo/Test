using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime);
    }
}