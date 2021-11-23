using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingY : MonoBehaviour
{
    public float anglePerSec = 90;

    // Update is called once per frame
    void Update()
    {
        Transform transform = GetComponent<Transform>();
        transform.Rotate(new Vector3(0, 0, 1), Time.deltaTime * anglePerSec);
    }
}
