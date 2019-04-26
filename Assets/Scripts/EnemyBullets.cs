using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullets : MonoBehaviour
{
    // Start is called before the first frame update
      public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
        float bulletPosition = GameObject.FindGameObjectWithTag("EnemyBullet").transform.position.y;

        if(bulletPosition < -5){
            Destroy(GameObject.FindGameObjectWithTag("EnemyBullet"));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(GameObject.FindGameObjectWithTag("EnemyBullet"));
        //Destroy(other.gameObject);
    }

}
