using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    public GameObject Player;

    void Update() {
        if (Input.GetButtonDown("1Key"))
        {
            Player.GetComponent<Animator>().Play("");
        }
        if (Input.GetButtonDown("2Key"))
        {
            Player.GetComponent<Animator>().Play("");
        }
        if (Input.GetButtonDown("3Key"))
        {
            Player.GetComponent<Animator>().Play("");
        }



        }
    }

