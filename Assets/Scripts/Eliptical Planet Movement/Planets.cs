using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets
{
    public int index;
        public GameObject planet;
        public float a;
        public float b;
        public float G;
        public float M;
        public Transform focus;
        public string name;

    public Planets()
    {

    }
    public Planets(int ind, GameObject obj, float a1, float b1, float G1, float M1, Transform trans, string str)
    {
        index = ind;
        planet = obj;
        a = a1;
        b = b1;
        G = G1;
        M = M1;
        focus = trans;
        name = str;
    }



}
