using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // how many frames to wait until another movement is taken.
    // analogous to speed, but higher FPM is slower and lower FPM is faster.
    public int framesPerMovement;
    // how many frames have passed since the last movement
    int frameCount;

    // path that the enemy will follow along.

    // (x, y, 0) as positions
    // these don't change.

    public Vector2[] path_2D;
    private Vector3[] path;

    // which position in path is the enemy at.
    int cycleIndex;

    private Animator animator;


    // will be implemented as soon as player characters are introduced.
    // enemies are simpler to implement movement, so they were done first.
    bool hasCaughtPlayerCharacter()
    {
        return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        frameCount = 0;
        cycleIndex = 0;

        // convert 2d to 3d
        path = new Vector3[path_2D.Length];
        for (int i = 0; i < path_2D.Length; i++)
            path[i] = new Vector3(path_2D[i].x, path_2D[i].y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        frameCount++;
        frameCount %= framesPerMovement;

        if (frameCount == 0)
        {
            // need movement on this frame
            cycleIndex += 1;
            cycleIndex %= path.Length;


            // move sprite
            transform.position = path[cycleIndex];

            int lastX = (int)transform.position.x;
            int lastY = (int)transform.position.y;

            Vector3 next = path[(cycleIndex + 1) % path.Length];


            int newX = (int)next.x;
            int newY = (int)next.y;

            int xD = newX - lastX;
            int yD = newY - lastY;


            if (xD > 0 && Math.Abs(xD) > Math.Abs(yD)) { // pos x
                animator.Play("right");
            } 
            else if (xD < 0 && Math.Abs(xD) > Math.Abs(yD)) { // neg x
                animator.Play("left");
            }
            else if (yD > 0 && Math.Abs(xD) < Math.Abs(yD)) { // pos y
                animator.Play("back");
            }
            else if (yD < 0 && Math.Abs(xD) < Math.Abs(yD)) { // neg y
                animator.Play("forward");
            }
        } else {
            Vector3 before = path[cycleIndex];
            Vector3 after = path[(cycleIndex + 1) % path.Length];

            transform.position = new Vector3(
                before.x * (1 - ((float)frameCount / (float)framesPerMovement)) + after.x * ((float)frameCount / (float)framesPerMovement),
                before.y * (1 - ((float)frameCount / (float)framesPerMovement)) + after.y * ((float)frameCount / (float)framesPerMovement),
                0
                );
        }

    }
}