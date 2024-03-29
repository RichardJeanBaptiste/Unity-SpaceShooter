﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.up * Time.deltaTime * speed);
        float bulletPosition = GameObject.FindGameObjectWithTag("Bullet").transform.position.y;

        if(bulletPosition > 6){
            Destroy(GameObject.FindGameObjectWithTag("Bullet"));
        }
    }

     void OnTriggerEnter2D(Collider2D other){
         
         if(other.gameObject.tag == "Player"){
             // do nothing
         }else if(other.gameObject.tag == "Gun"){
             //do nothing
         }else{
             
             //Destroy(other.gameObject);
             Destroy(GameObject.FindGameObjectWithTag("Bullet"));
         }
     }
}
