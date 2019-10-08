using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizeOrbit : MonoBehaviour
{
    LineRenderer line;
    public float alpha;
    public float a;
    public float b;

    private void Start()
    {
        line = GetComponent<LineRenderer>();

    }

    private void Update()
    {
        for(int i=0; i < line.positionCount;i++)
        {
            alpha = alpha + 360 / (line.positionCount - 1) * Mathf.Deg2Rad;
            line.SetPosition(i, new Vector3(a * Mathf.Sin(alpha), 0, b * Mathf.Cos(alpha)));

        }
        alpha = 0;

        transform.Rotate(Vector3.up * -0.1f);
    }
}
