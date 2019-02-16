using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // how many frames to wait until another movement is taken.
    // analogous to speed, but higher FPM is slower and lower FPM is faster.
    int framesPerMovement;
    // how many frames have passed since the last movement
    int frameCount;

    // path that the enemy will follow along.
    Vector3[] path;
    // which position in path is the enemy at.
    int cycleIndex;


    // will be implemented as soon as player characters are introduced.
    // enemies are simpler to implement movement, so they were done first.
    bool hasCaughtPlayerCharacter() {
        return false;
    }

    // Start is called before the first frame update
    void Start() {
        // initial conditions
        framesPerMovement = 30;
        frameCount = 0;
        cycleIndex = 0;

        // (x, y, 0) as positions
        // these don't change.
        path = new Vector3[] {
            new Vector3(0, -2, 0),
            new Vector3(1, -2, 0),
            new Vector3(2, -2, 0),
            new Vector3(3, -2, 0),
            new Vector3(4, -2, 0),
            new Vector3(3, -2, 0),
            new Vector3(2, -2, 0),
            new Vector3(1, -2, 0)
        };
    }

    // Update is called once per frame
    void Update() {
        frameCount++;
        frameCount %= framesPerMovement;

        if (frameCount == 0) {
            // need movement on this frame
            cycleIndex += 1;
            cycleIndex %= path.Length;

            // move sprite
            transform.position = path[cycleIndex];
        }
    }
}
