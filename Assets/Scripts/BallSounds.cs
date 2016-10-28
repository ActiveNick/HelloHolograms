using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSounds : MonoBehaviour {

    public AudioSource bouncingAudio;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        // Play an impact sound if the ball impacts strongly enough.
        if (collision.relativeVelocity.magnitude >= 0.1f)
        {
            bouncingAudio.Play();
        }

    }
}
