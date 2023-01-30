/*
 * Gerard Lamoureux
 * UpdatePlayerDamageUI.cs
 * Assignment2
 * Handles Player Damage UI
 */

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdatePlayerDamageUI : MonoBehaviour
{
    [SerializeField] PlayerController pc;
    [SerializeField] TextMeshProUGUI text;

    // Update is called once per frame
    void Update()
    {
        text.text = "Damage: " + pc.Damage;
    }
}
