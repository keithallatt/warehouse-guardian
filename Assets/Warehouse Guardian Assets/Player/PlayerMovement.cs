using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rbody;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>(); //gets the components that are attached to the player in unity
        anim = GetComponent<Animator>(); //gets the components that are attached to the player in unity
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); //returns us true or false. ex pressing left makes horz -1 and releasing makes it 0

        if (movement_vector != Vector2.zero)
        {
            anim.SetBool("iswalking", true);
            anim.SetFloat("input_x", movement_vector.x);
            anim.SetFloat("input_y", movement_vector.y);
        }
        else
        {
            anim.SetBool("iswalking", false);
        }

        rbody.MovePosition (rbody.position + movement_vector * Time.deltaTime); //moving over 1 meter per 60 frames
    }
}
