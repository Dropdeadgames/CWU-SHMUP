using UnityEngine;
using System.Collections;

public class destroyInvisible : MonoBehaviour
{
    public GameObject destroyTarget = null;

    void OnBecameInvisible ()
    {
        if (destroyTarget == null)
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(destroyTarget);
        }
    }
}
