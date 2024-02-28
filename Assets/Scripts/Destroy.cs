using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject Pomoi;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sosat")

        {
            Destroy(Pomoi);
        }
    }
}
