using UnityEngine;
using System.Collections;

public class enemyDrop : MonoBehaviour
{
    public GameObject enemy = null;
    public float delay = 2.0f;

    void Start ()
    {
        if (enemy != null)
        {
            InvokeRepeating("Spawn", 0.0f, delay);
        }
    }
	
	void Spawn ()
    {
        Instantiate(enemy, new Vector3(Random.Range(-3.0f, 3.0f), 5.0f, 0.0f), enemy.transform.rotation);
	}
}
