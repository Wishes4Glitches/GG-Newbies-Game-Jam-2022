using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;

    private Animator anim;

    void start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }

        anim.SetBool("IsEating", true);
        anim.SetBool("IsEating", false);
    }
}
