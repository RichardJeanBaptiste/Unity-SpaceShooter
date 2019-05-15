using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public float speed;

    public int hitPoints;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        var pos = Camera.main.ScreenToWorldPoint( new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 5));
        
        transform.position = new Vector3(pos.x, pos.y + 0.3f, pos.z);

        if(transform.position.x > 1.94){
            transform.position = new Vector3(1.94f, transform.position.y, pos.z);
        }

        if(transform.position.x < -1.94){
            transform.position = new Vector3(-1.94f, transform.position.y, pos.z);
        }


        /* 
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);
        transform.Translate(Vector2.up * vertical * Time.deltaTime * speed);

        if(transform.position.x > 1.94){
            transform.position = new Vector2(1.94f, transform.position.y);
        }

        if(transform.position.x < -1.94){
            transform.position = new Vector2(-1.94f, transform.position.y);
        }
        */

    }

    void OnTriggerEnter2D(Collider2D other)
    {
       
        if(other.gameObject.tag == "Bullet"){
            //do nothing
        }else{
            hitPoints--;
            if(hitPoints <= 0){
                Destroy(gameObject);
            }
        }

    }

}
