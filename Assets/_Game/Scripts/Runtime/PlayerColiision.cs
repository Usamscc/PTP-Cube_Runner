using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColiision : MonoBehaviour
{
    [SerializeField] private PlayerMovement movement;
    [SerializeField] private GameManager gameManager;
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag=="Obstacle") {
            movement.enabled = false;
            print("Collision occured");
            GameManager.instance.EndGame();
        }
    }
}
