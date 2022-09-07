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

    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
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

            GameObject thePlayer = GameObject.Find("Player");
            Health playerScript = thePlayer.GetComponent<Health>();
            PlayerMovement playerAnim = thePlayer.GetComponent<PlayerMovement>();
            playerAnim.anim.Play("Eating");

            if (playerScript.health >= 81)
            {
                playerScript.health = 100;
            }
            else
            {
                playerScript.health += 20;
            }
        }
    }

    /*void Instantiate()
    {
        int spawn = Random.Range(0, spawnLocations.Length);
        Instantiate(slime, spawnLocations[spawn].transform.position, Quaternion.identity);
    }*/
}
