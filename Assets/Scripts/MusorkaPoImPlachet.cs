using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusorkaPoImPlachet : MonoBehaviour
{
    public GameObject barrier1;
    public GameObject Trash1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bruh")
        {
            Destroy(barrier1);
            Destroy(Trash1);
        }
    }
}
