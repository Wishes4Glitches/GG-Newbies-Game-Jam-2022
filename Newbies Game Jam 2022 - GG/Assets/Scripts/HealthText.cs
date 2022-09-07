using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthText : MonoBehaviour
{
    private void Start()
    {
        TextMeshPro screenText = GetComponent<TextMeshPro>();
        screenText.text = "Health: ";
    }

    private void Update()
    {
        TextMeshPro screenText = GetComponent<TextMeshPro>();

        GameObject health = GameObject.Find("Player");
        Health healthScript = health.GetComponent<Health>();
        screenText.text = "Health: " + healthScript.health;
    }
}
