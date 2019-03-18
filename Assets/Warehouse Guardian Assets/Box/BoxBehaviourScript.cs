using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float thrust;
    public Rigidbody rb;
    Rigidbody m_Rigidbody;
    float m_Speed;
    int count;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_Speed = 10.0f;
        m_Rigidbody = GetComponent<Rigidbody>();
        count = 0;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("end point"))
        {
            count = count + 1;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * thrust);
        if (Input.GetKey(KeyCode.W))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = transform.forward * m_Speed;

        }

        if (Input.GetKey(KeyCode.S))
        {
            //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = -transform.forward * m_Speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            //Rotate the sprite about the Y axis in the positive direction
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * m_Speed, Space.World);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Rotate the sprite about the Y axis in the negative direction
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * m_Speed, Space.World);
        }
    }
}
