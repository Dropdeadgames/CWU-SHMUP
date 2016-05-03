using UnityEngine;
using System.Collections;

public class powerUpManager : MonoBehaviour
{
    public GameObject[] weapons;
    private int powerLevel = 0;

    void PowerUp()
    {
        powerLevel++;
        if (powerLevel < weapons.Length)
        {
            weapons[powerLevel].SetActive(true);
        }
    }
}
