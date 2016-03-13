using UnityEngine;
using System.Collections;

public class enemyAttack : MonoBehaviour
{
    public GameObject sprite = null;
    public float delay = 0.2f;

    void Start ()
    {
        Invoke("shot", delay);
    }

    void shot ()
    {
        Instantiate(sprite, transform.position, transform.rotation);
        Invoke("shot", delay);
    }
}
