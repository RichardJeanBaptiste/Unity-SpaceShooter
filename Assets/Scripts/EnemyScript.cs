using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public bool move;

    public int HitPoints;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LeftToRight();
    }

   void LeftToRight(){

       if(transform.position.x > 2.0){
           move = false;
       }else if(transform.position.x < -2.0){
           move = true;
       }

       if(move){
           transform.Translate(Vector2.right * Time.deltaTime * speed);
       }else{
           transform.Translate(Vector2.left * Time.deltaTime * speed);
       }

   }

   void OnTriggerEnter2D(Collider2D other)
   {
       HitPoints--;
       if(HitPoints <= 0){
           Destroy(gameObject);
       }
   }
   
}
