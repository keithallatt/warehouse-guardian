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
        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>(); //allows us to access the animator that was attached to player
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); //returns us true or false, ex if we press "A" key horizontal will become -1

        if (movement_vector != Vector2.zero)
        {
            anim.SetBool("iswalking", true);
            anim.SetFloat("input_x", movement_vector.x); //we set these two so that it keeps facing the last direction
            anim.SetFloat("input_y", movement_vector.y);
        }
        else
        {
            anim.SetBool("iswalking", false);
        }

        rbody.MovePosition(rbody.position + movement_vector * Time.deltaTime); //moves 1m per frame
    }
}
