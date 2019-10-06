using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalMovement : MonoBehaviour
{
    public int index = 0;
    [SerializeField] public float a;
    [SerializeField] public float b;
    [SerializeField]  float c;
    [SerializeField] float alpha;
    [SerializeField] float deltaAlpha;

    [SerializeField] Vector3 center;
    [SerializeField] public Transform focus1;

    [SerializeField] public float G;
    [SerializeField] public float M;


    float r;
    Rigidbody rb;
    TrailRenderer tr;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        tr = GetComponent<TrailRenderer>();

        tr.Clear();
        Invoke("StartTrail", 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        center = new Vector3(focus1.position.x + c, 0, focus1.position.z);
        r = Vector3.Distance(focus1.position, transform.position);

        transform.position = new Vector3(center.x + a * Mathf.Cos(alpha), 0, center.z + b * Mathf.Sin(alpha));

        c = Mathf.Sqrt(Mathf.Abs(a * a - b * b));

        //deltaAlpha = (Mathf.Sqrt(Mathf.Abs(2 * G * M * (1/r - 1/(2 * a))) * (180) * Time.deltaTime) / Mathf.PI * (3*(a+b)-Mathf.Sqrt((3*a+b)*(a+3*b))));
        deltaAlpha = Mathf.Sqrt(G * M / r) * Time.deltaTime * 100;        
        //deltaAlpha = 2 * Mathf.PI * r;
        alpha += deltaAlpha ;
    }

    void StartTrail()
    {
        tr.emitting = true;

    }
}
