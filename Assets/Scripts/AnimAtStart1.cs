using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimAtStart : MonoBehaviour
{
    void Start()
    {
        anim.Play("start");
    }

    public Animator anim;
}
