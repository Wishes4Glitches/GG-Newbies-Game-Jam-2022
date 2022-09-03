using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SlimePossession : MonoBehaviour
{
    /*public GameObject ghost;
    public GameObject slime;

    public PlayerMovement movement;

    public Camera slimeCamera;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ghost")
        {
            Destroy(col.gameObject);
            slimeCamera.enabled = true;
            movement.enabled = true;
            Debug.Log("Touching");
        }
        else if (col.tag == "Player")
        {
            Destroy(gameObject);
            slimeCamera.enabled = false;
            Instantiate(slime, col.transform.position + new Vector3(0, 2, 0), Quaternion.identity);

            Instantiate(ghost, col.transform.position + new Vector3(3, 0, 0), Quaternion.identity);
        }
    }*/ //Old Broken Code

    public GameObject slime;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Slime")
        {
            //SpawnListener.summon += Instantiate();
        }
    }
    void Instantiate()
    {
        Instantiate(slime, new Vector3(2, 2, 0), Quaternion.identity);
    }
}
