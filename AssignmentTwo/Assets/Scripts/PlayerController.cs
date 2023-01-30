/*
 * Gerard Lamoureux
 * PlayerController.cs
 * Assignment2
 * Handles Player and their fly mode
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Damageable
{
    protected int flyLength = 0;
    protected Coroutine flyCoroutine;

    public static PlayerController thisPlayerController;

    public int FlyLength { get => flyLength; }
    protected override void Awake()
    {
        base.Awake();
        health = 10;
        SetFlyMode(new CantFly());
        thisPlayerController = this;
    }

    public override void SetFlyMode(IFlyable flyable)
    {
        base.SetFlyMode(flyable);
        if (TryToFly())
        {
            flyLength = 15;
            if (flyCoroutine != null)
                StopCoroutine(flyCoroutine);
            flyCoroutine = StartCoroutine(FlyTime());
        }
        else
        {
            if (flyCoroutine != null)
                StopCoroutine(flyCoroutine);
        }
    }

    private IEnumerator FlyTime()
    {
        while(flyLength > 0)
        {
            yield return new WaitForSeconds(1);
            flyLength--;
        }
        SetFlyMode(new CantFly());
    }
}
