using UnityEngine;
using System.Collections;

public class enemyMove : MonoBehaviour
{
    public float speed = 1.0f;
    public float sinAmplitue = 1.0f;
    public float sinFrequency = 1.0f;
    private float horizontalOffset = 0.0f;
    private float time;

	// Update is called once per frame
	void Update ()
    {
        time += Time.deltaTime;

        // Remove offset
        transform.position -= horizontalOffset * transform.right;

        // Moves Enemy forward
        transform.position -= transform.forward * speed * Time.deltaTime;

        // Adjust horizontal position by sine wave
        horizontalOffset = Mathf.Sin(time * sinFrequency * 2 * Mathf.PI) * sinAmplitue;
        transform.position += horizontalOffset * transform.right;
    }
}
