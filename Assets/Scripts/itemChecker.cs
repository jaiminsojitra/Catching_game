using UnityEngine;
using System.Collections;

public class ObjectCollector : MonoBehaviour
{

    //variable for score counting
    public int score;

    //will be started, if one GameObject with Collider2D has touched the Trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        //check if GameObjects Tag is Good
        if (other.gameObject.tag == "Good")
        {
            //if Tag is Good increase score
            score = score + 10;
            //delete GameObject, which went into Trigger, from the Scene
            Destroy(other.gameObject);
        }
        //check if GameObjects Tag is Bad
        if (other.gameObject.tag == "Bad")
        {
            //if Tag is Bad decrease score
            score = score - 10;
            //delete GameObject, which went into Trigger, from the Scene
            Destroy(other.gameObject);
        }
    }
}