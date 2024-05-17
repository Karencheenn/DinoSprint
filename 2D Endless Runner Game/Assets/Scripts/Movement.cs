using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float movementSpeed;
    public float startPosition;
    public float endPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // to update ground position
        transform.position = new Vector2(transform.position.x - movementSpeed * Time.deltaTime, transform.position.y);

        //if the ground has reached its endpt, it will have to return to its startposition
        if (transform.position.x <= endPosition) {
            if (gameObject.tag == "Cactus") { // if a cactus has reached to the leftmost pt
                Destroy(gameObject);
            } else {
              transform.position = new Vector2(startPosition, transform.position.y);
            }
        }
    }
}
