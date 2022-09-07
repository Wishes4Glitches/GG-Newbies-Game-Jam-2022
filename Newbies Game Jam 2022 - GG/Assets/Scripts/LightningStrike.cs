using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningStrike : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Health playerHealth = Player.GetComponent<Health>();
            playerHealth.health -= 20;
            Debug.Log("Hurt");
        }
    }
}
