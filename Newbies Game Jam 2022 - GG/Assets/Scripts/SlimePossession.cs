using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SlimePossession : MonoBehaviour
{
    public GameObject slime;
    public GameObject player;

    public GameObject[] spawnLocations;

    public SpriteRenderer sprRend;
    public Sprite slimeModel;
    public Sprite ghostModel;

    void Awake()
    {
        spawnLocations = GameObject.FindGameObjectsWithTag("Spawnpoint");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Slime")
        {
            Destroy(col.gameObject);

            sprRend.sprite = slimeModel;
        }
        else if (col.tag == "Player" && sprRend.sprite == slimeModel)
        {
            sprRend.sprite = ghostModel;
            Instantiate();
        }
    }

    void Instantiate()
    {
        int spawn = Random.Range(0, spawnLocations.Length);
        Instantiate(slime, spawnLocations[spawn].transform.position, Quaternion.identity);
    }
}
