/*
 * Gerard Lamoureux
 * UpdatePlayerHealth.cs
 * Assignment2
 * Handles Player Health UI
 */

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdatePlayerHealth : MonoBehaviour
{
    [SerializeField] PlayerController pc;
    [SerializeField] TextMeshProUGUI text;

    // Update is called once per frame
    void Update()
    {
        text.text = "Health: " + pc.Health;
    }
}
