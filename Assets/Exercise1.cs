using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    //VARIABLES
    private float speed = 0;
    private Vector2 direction = Vector2.right;


    /******************************
      * Create a coroutine  called ChangeDirection()
      * 
      * Set speed to 1
      * Set direction to Vector2.right
      * Wait 1 second
      * Set direction to Vector2.left
      * Wait 1 second
      * Set speed to 0
      ******************************/

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        //Start the ChangeDirection coroutine if the A key is pressed.


       
    }


    /******************************
     * 
     ******************************/



}
