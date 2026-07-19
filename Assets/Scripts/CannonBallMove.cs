//using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CannonBallMove : MonoBehaviour
{
    private int speed = 100;
    private float destroyDelaySeconds = 0.3F;

    Rigidbody cbody;
    // Start is called before the first frame update
    void Start()
    {
         cbody = this.gameObject.GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy") 
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EndSensor")
        {
            speed = 999;
            Destroy(this.gameObject, destroyDelaySeconds);
        }
    }
    void Update()
    {

        //cbody.linearVelocity = transform.forward * 10;
        //* Time.deltaTime;
        // cbody.linearVelocity = new Vector3(0,0,1);
        cbody.linearVelocity = transform.forward * speed;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //Rigidbody cbody = this.GetComponent<Rigidbody>();
        //cbody.linearVelocity = transform.right * 100000 * Time.deltaTime;
        
    }
}
