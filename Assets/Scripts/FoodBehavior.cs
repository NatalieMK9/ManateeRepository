using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodBehavior : MonoBehaviour
{
    //vector to be used for bouncing food
    Vector3 temp = new Vector3(0, 3, 0);

    void Start()
    {
    }

    //when something collides to a food gameObject
    void OnCollisionEnter(Collision collision)
    {
        //if the player is colliding to the food
        if (collision.gameObject.name == "waterHyacinth" || collision.gameObject.name == "alligatorWeed" || collision.gameObject.name == "eelGrass") )
        {
            //make player do a bounce animation
            collision.gameObject.transform.position += temp;
            
            //destroy the object
            Destroy(this.gameObject);
            //change the text on the screen
            collision.gameObject.GetComponent<ManateeBehavior>().changeText(1);
        }
    }
}
