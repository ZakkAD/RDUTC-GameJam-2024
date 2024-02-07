using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
	new Camera cam;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;


    public PlayerController player1Script;
    public PlayerController player2Script;


    private Transform target;

    void Start()
    {
        // Start by following player 1
        target = player1;
    }

    void Awake () {
		cam = GetComponent<Camera>();
	}

    void LateUpdate()
    {
        if (target == null)
            return;

        Vector3 desiredPosition = target.position + offset;
        desiredPosition.z = transform.position.z; // Keep the z position constant
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }

    void Update()
    {
        // Switch target to player 1 when 'K' is pressed
        if (Input.GetKeyDown(KeyCode.W))
        {
            Console.WriteLine("K pressed");
            player1Script.beingControlled = true;
            player2Script.beingControlled = false;
            target = player1;
            FlipCamera(false);
        }

        // Switch target to player 2 when 'L' is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            Console.WriteLine("K pressed");
            player2Script.beingControlled = true;
            player1Script.beingControlled = false;
            target = player2;
            FlipCamera(true);
        }
    }

    void FlipCamera(bool flipY)
    {
        cam.ResetWorldToCameraMatrix();
        cam.ResetProjectionMatrix();

        Vector3 scale = new Vector3(1, flipY ? -1 : 1, 1);
        cam.projectionMatrix = cam.projectionMatrix * Matrix4x4.Scale(scale);
    }
}
