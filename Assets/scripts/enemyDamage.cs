using UnityEngine;
using System.Collections;

public class enemyDamage : MonoBehaviour
{
    public GameObject gib;

    void OnTriggerEnter ()
    {
        if (gib != null)
        {
            Instantiate(gib, transform.position, gib.transform.rotation);
        }
        Destroy(gameObject);
    }
}
