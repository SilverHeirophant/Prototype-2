using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // destroies target and food item when collide. Adds to score by 1
        Destroy(gameObject);
        Destroy(other.gameObject);

        score = score + 1;
    }
}
