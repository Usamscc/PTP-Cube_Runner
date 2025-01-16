using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] private Rigidbody rb;
   [SerializeField] private float playerSpeed = 50f;
   [SerializeField] private float playerSidewaySpeed = 100f;

   private float horizontal;
    // Start is called before the first frame update
    void Start()
    {
        print("Working");
    }

    // Update is called once per frame
    void  FixedUpdate()
    {
          rb.AddForce(0,0,playerSpeed * Time.fixedDeltaTime);
          horizontal=Input.GetAxis("Mouse X");
        
         print("mouse position "+ horizontal);
       
         rb.AddForce(playerSidewaySpeed * Time.deltaTime*horizontal,0,0,ForceMode.VelocityChange);

         if (rb.position.y < -2f)
         {
           GameManager.instance.EndGame();
         }
         
        
    }
}
