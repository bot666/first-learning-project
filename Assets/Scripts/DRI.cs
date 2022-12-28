using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DRI : MonoBehaviour
{
 [SerializeField] float steerSpeed = 1f;
  [SerializeField] float moveSpeed= 20;
  [SerializeField] float slowSpeed = 15;
  [SerializeField] float boostSpeed = 30;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
      float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
      transform.Rotate(0, 0, -steerAmount);
      transform.Translate(0,moveAmount,0);
      
    }
    void OnTriggerEnter2D(Collider2D other)
    {
      if(other.tag == "Boost")
      {
        moveSpeed = boostSpeed;
      
    }
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
  
    {
      moveSpeed = slowSpeed;    
    }

}
