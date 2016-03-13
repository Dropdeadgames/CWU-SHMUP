using UnityEngine;
using System.Collections;

public class playerAttack : MonoBehaviour
{
    public GameObject sprite = null;
    public float delay = 0.2f;
    private bool readyToFire = true;

	void Update ()
    {
        if (Input.GetButton("Fire1") && readyToFire)
        {
            Instantiate(sprite, transform.position, sprite.transform.rotation);
            readyToFire = false;
            Invoke("resetShot", delay);
        }
	}

    void resetShot ()
    {
        readyToFire = true;
    }
}
