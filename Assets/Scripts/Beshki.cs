using UnityEngine;

public class Beshki : MonoBehaviour
{
    public GameObject[] Particles;
    public Animator Door1, Door2, Door3, Door4;

    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag=="hand")
        {
            foreach(GameObject particle in Particles)
            {
                particle.SetActive(true);
            }

            Door1.transform.rotation = Quaternion.Euler(90, 0, 90);
            Door2.transform.rotation = Quaternion.Euler(90, 0, 90);
            Door3.transform.rotation = Quaternion.Euler(90, 0, 90);
            Door4.transform.rotation = Quaternion.Euler(90, 0, 90);
        }
    
    }
}
