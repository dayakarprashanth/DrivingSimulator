using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 20.0f;
    private float _turnspeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // To get inputs from the player
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //We move the vehicle forward
        transform.Translate(Vector3.forward * _speed * Time.deltaTime * forwardInput);


        //transform.Translate(Vector3.right * _turnspeed * Time.deltaTime * horizontalInput);
        //to Rotate/Steer the Object based on the Horizontal Input
        transform.Rotate(Vector3.up, _turnspeed * Time.deltaTime * horizontalInput);
    }
}
