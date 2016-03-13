using UnityEngine;
using System.Collections;

public class destroyParticle : MonoBehaviour
{
    public ParticleSystem ps = null;

	void Update ()
    {
	    if (ps)
        {
            if (!ps.IsAlive())
            {
                Destroy(gameObject);
            }
        }
	}
}
