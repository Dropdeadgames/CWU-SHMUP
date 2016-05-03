using UnityEngine;
using System.Collections;

public class powerUp : MonoBehaviour
{

    void OnTriggerEnter()
    {
        GameObject.FindGameObjectWithTag("Player").SendMessage("PowerUp");
        Destroy(gameObject);
    }
}
