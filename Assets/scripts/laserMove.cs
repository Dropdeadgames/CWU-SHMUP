using UnityEngine;
using System.Collections;

public class laserMove : MonoBehaviour
{
    public float speed = 1.0f;
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
	}

    // Destroy laser on contact
    void OnTriggerEnter ()
    {
        Destroy(gameObject);
    }
}
