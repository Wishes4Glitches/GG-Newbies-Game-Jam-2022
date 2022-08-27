using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimePossession : MonoBehaviour
{
    public GameObject ghost;
    public GameObject slime;

    public PlayerMovement movement;
    public BoxCollider2D col;

    public Camera slimeCamera;
    public Camera ghostCamera;

    private void Awake()
    {
        //col = add
    }

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
            Instantiate(ghost, col.transform.position + new Vector3(3, 0, 0), Quaternion.identity);
            Instantiate(slime, col.transform.position + new Vector3(10, 0, 0), Quaternion.identity);
        }
    }
}
