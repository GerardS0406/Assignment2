/*
 * Gerard Lamoureux
 * EnemyController.cs
 * Assignment2
 * Handles enemies and their text
 */

using UnityEngine;
using TMPro;

public class EnemyController : Damageable
{
    [SerializeField] TextMeshProUGUI text;

    private void Update()
    {
        text.text = "Enemy\nHealth\n" + health;
    }
}

