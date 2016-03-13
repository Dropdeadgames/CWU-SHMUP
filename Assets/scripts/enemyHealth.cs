using UnityEngine;
using System.Collections;

public class enemyHealth : MonoBehaviour
{
    public int initialHealth = 10;
    public GameObject hitEffect;
    public GameObject deathEffect;

    private int currentHealth;

	void Start ()
    {
        currentHealth = initialHealth;	
	}

    void OnTriggerEnter ()
    {
        currentHealth--;
        Instantiate(hitEffect, transform.position, Quaternion.identity);
        if (currentHealth <= 0)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
