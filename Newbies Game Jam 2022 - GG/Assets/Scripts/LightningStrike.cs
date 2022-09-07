using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningStrike : MonoBehaviour
{
    public GameObject Player;

    public Animation anim;
    public AnimationClip animClip;
    float waitTime;

    private void Start()
    {
        anim = GetComponent<Animation>();
        waitTime = animClip.length + 5.0f;
        InvokeRepeating("PlayAnim", 5.0f, waitTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Health playerHealth = Player.GetComponent<Health>();
            playerHealth.health -= 20;
            Debug.Log("Hurt");
        }
    }

    void PlayAnim()
    {
        anim.clip = animClip;
        anim.Play();
    }
}
