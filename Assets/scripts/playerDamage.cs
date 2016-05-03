using UnityEngine;
using System.Collections;

public class playerDamage : MonoBehaviour
{
    public GameObject gib;

    void OnTriggerEnter ()
    {
        if (gib != null)
        {
            Instantiate(gib, transform.position, gib.transform.rotation);
        }
        Destroy(transform.parent.gameObject);
    }
}
