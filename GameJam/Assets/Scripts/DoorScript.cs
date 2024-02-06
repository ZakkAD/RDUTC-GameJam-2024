using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool button;
    public float smoothTime = 0.5f;
    public float speed = 10;
    Vector3 velocity;

    //move object to a set position     
    transform.position = new Vector3(Doorx, Doory+10,1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(Door.y+10, ref velocity, smoothTime, speed);
    }
}
