using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeConsumption : MonoBehaviour
{
    public BoxCollider2D bc2d;

    public Camera slimeCamera;
    public Camera ghostCamera;

    void Start()
    {
        bc2d = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ghost")
        {
            Destroy(col.gameObject);
            slimeCamera.enabled = true;
            ghostCamera.enabled = false;
            this.GetComponent<PlayerMovement>().enabled = true;
            Debug.Log("Touching");
        }
    }
}
