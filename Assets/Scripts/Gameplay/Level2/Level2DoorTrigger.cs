﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2DoorTrigger : MonoBehaviour
{
    bool playerIn;
    public GameObject DoorLeft;
    public GameObject DoorRight;
    Animator DoorLeftAnim;
    Animator DoorRightAnim;

    private void Start()
    {
        DoorLeftAnim = DoorLeft.GetComponent<Animator>();
        DoorRightAnim = DoorRight.GetComponent<Animator>();
    }

    private void Update()
    {
        if(playerIn == true && Input.GetKeyDown(KeyCode.E) == true)
        {
            DoorLeftAnim.SetBool("OnSpot", true);
            DoorLeftAnim.SetBool("PressE", true);
            
            DoorRightAnim.SetBool("OnSpot", true);
            DoorRightAnim.SetBool("PressE", true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerIn = true;
            Debug.Log("The State of playerIn is " + playerIn);
        }
    }

    void onTriggerExit(Collider collision)
    {
        playerIn = false;
    }

    

}
