﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionSoundsBehaviour : MonoBehaviour
{
    public AudioSource soundFXWall;
    public AudioSource soundFXBrickHit;
    public AudioSource soundFXBrickBroken;
    public AudioSource soundTrack;

    // Start is called before the first frame update
    void Start()
    {
       // soundTrack.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "TagWall" || collision.collider.tag == "TagPaddle")
        {
            soundFXWall.Play();
        }
        else if (collision.collider.tag == "TagBrick")
        {
            //if (collision.collider.GetComponent<BrickCrackBehaviour>().getLife() > 1)
            soundFXBrickHit.Play();
        }
        else
        {
            soundFXBrickBroken.Play();
        }
    }
}