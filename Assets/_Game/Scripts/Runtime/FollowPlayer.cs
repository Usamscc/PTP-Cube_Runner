using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
   [SerializeField] private GameObject player;
   private Vector3 spaceFromPlayer=new Vector3(0, 2, -5);
   

    private void LateUpdate()
    {
        gameObject.transform.position=spaceFromPlayer + player.transform.position;
    }
}
