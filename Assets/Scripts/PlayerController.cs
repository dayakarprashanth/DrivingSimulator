using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public float _speed = 5.0f;
    public float _turnspeed;
    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //We will move the vehicle forward
        transform.Translate(Vector3.forward * _speed * Time.deltaTime * forwardInput);
        transform.Translate(Vector3.right * _turnspeed * Time.deltaTime * horizontalInput);
    }
}
