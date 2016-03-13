using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour
{
    public float speed = 1.0f;

	void Update ()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f) * speed * Time.deltaTime;
    }
}
