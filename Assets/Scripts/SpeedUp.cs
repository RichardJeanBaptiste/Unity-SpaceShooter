using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")){
            speedUp(other);
            Destroy(gameObject);
        }
    }

    void speedUp(Collider2D player)
    {
        Ship stats = player.GetComponent<Ship>();
        stats.speed += 5;
    }
}
