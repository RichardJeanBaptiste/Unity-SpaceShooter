using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.3f, 2.3f), transform.position.y, transform.position.z);

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 TouchPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(TouchPosition.x * speed * Time.deltaTime, 0,0);
        }
    }
}
