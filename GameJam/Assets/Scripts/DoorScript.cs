using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    
    public float moveSpeed;
    private Vector3 doorUp;
    private Vector3 doorDown;
    public float heightIncrease;
    public buttonScript button;

    void Start(){

        doorUp = gameObject.transform.position;
        doorUp.y += heightIncrease;
        doorDown = gameObject.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (button.value == false)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, doorDown, Time.deltaTime * moveSpeed);
        }

        if (button.value == true)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, doorUp, Time.deltaTime * moveSpeed);
        }
    }
}
