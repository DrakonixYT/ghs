using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class ass : MonoBehaviour
{
    public GameObject light;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hand")
  
        {
            light.SetActive(true);
        }
    }
        
        
}
