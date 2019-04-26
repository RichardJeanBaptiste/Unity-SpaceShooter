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

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        hitPoints--;
        if(hitPoints <= 0){
            Destroy(gameObject);
        }
    }
}
