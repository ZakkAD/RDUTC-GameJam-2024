using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject door;
    public float moveSpeed;
    public Transform doorUp;
    public Transform doorDown;
    public bool button;

    // Update is called once per frame
    void Update()
    {
        if (button == false)
        {
            door.transform.position = Vector3.MoveTowards(door.transform.position, doorDown.transform.position, Time.deltaTime * moveSpeed);
        }

        if (button == true)
        {
            door.transform.position = Vector3.MoveTowards(door.transform.position, doorUp.transform.position, Time.deltaTime * moveSpeed);
        }
    }
}
