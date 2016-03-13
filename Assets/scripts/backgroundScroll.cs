using UnityEngine;
using System.Collections;

public class backgroundScroll : MonoBehaviour
{
    public float verticalScrollSpeed = 1.0f;
    public float horizontalScrollMulti = 1.0f;
    private GameObject player;

	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");	
	}
	
	void Update ()
    {
        if (player != null)
        {
            Vector2 newTextureOffset = GetComponent<Renderer>().material.mainTextureOffset;

            newTextureOffset.y += verticalScrollSpeed * Time.deltaTime;
            newTextureOffset.x = player.transform.position.x * horizontalScrollMulti;

            GetComponent<Renderer>().material.mainTextureOffset = newTextureOffset;
        }
        else
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
	}
}
