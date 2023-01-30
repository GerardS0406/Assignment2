/*
 * Gerard Lamoureux
 * FlyCountdownUI.cs
 * Assignment2
 * Handles Fly Countdown UI
 */

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlyCountdownUI : MonoBehaviour
{
    [SerializeField] PlayerController pc;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] GameObject countdownObj;

    // Update is called once per frame
    void Update()
    {
        text.text = "Fly Countdown: " + pc.FlyLength;
    }
}
