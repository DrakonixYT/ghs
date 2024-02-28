using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anima : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim.Play("start");
    }
}
