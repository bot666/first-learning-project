using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
   bool hasPckage;
  [SerializeField] float destroyDelay;
  [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
  [SerializeField] Color32 hasNoPackageColor = new Color32 (1, 0, 0, 1);
  SpriteRenderer spriteRenderer;
   

   void Start()
   {
      spriteRenderer = GetComponent<SpriteRenderer>();
      
   }

   void OnCollisionEnter2D(Collision2D collisionInfo)
   {
    Debug.Log("khord");
   }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && hasPckage == false)
        {
         Debug.Log("Package picked up!!");
         hasPckage = true;
         Destroy(other.gameObject, destroyDelay);
         spriteRenderer.color = hasPackageColor;
         
        }


        
        if (other.tag == "Customer" && hasPckage)
        {
         Debug.Log("package delivered");
         hasPckage = false;
            spriteRenderer.color = hasNoPackageColor;
        }

    }

}
