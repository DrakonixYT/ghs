using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillIssue : MonoBehaviour
{
    public GameObject[] Particles;
    public Animator Door1, Door2, Door3, Door4;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hand")
        {
            foreach (GameObject particle in Particles)
            {
                particle.SetActive(false);
            }

            Door1.transform.rotation = Quaternion.Euler(90, 0, 0);
            Door2.transform.rotation = Quaternion.Euler(90, 0, 0);
            Door3.transform.rotation = Quaternion.Euler(90, 0, 0);
            Door4.transform.rotation = Quaternion.Euler(90, 0, 0);
        }

    }
}
