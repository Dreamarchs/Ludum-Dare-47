﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockScript : MonoBehaviour
{
    /* bool HasRock = false;
     bool IsHolding = false;
     MeshRenderer rockMesh = GameObject.Find("Rock1").GetComponent<MeshRenderer>();
     BoxCollider rockCollider = GameObject.Find("Rock1").GetComponent<BoxCollider>();
     GameObject rock = GameObject.Find("Rock1");
     GameObject player = GameObject.Find("Player"); // get the player gameobject so we can drop the rock whereever the player is standing


     private void Update()
     {

         if (HasRock == false) //check if the player doesn't have the rock
         {

             if (Input.GetKeyDown(KeyCode.E)) // also check if player is targeting/mouse hovering rock
             {
                 PickUp(); // runs the pickup
             }
             else 
             {
                 return;
             }

         }

         if (HasRock == true) 
         {
             rockMesh.enabled = false;
             rock.transform.position = player.transform.position;

             if (Input.GetKeyDown(KeyCode.Mouse0) && IsHolding == true) 
             {
                 DropRock();     // DropRock is suppose to run when the player left clicks the mouse
             }
             else
             {
                 return;
             }
         }


     }  

     private void PickUp() // pick rock the if in range
     {

         if (HasRock == false) 
         {
             rock.GetComponent<Rigidbody>().useGravity = false;

             HasRock = true; // sets has rock to true
             rockMesh.enabled = false; // turn what shows the rock 
             rockCollider.enabled = false; // set collider to be off to avoid any potential problems
         }
         else
         {
             return;
         }
     }

     private void DropRock() // drops the rock if it's being held at the players current standing position or slightly off if wanted
     {
         if(HasRock == true && IsHolding == true)
         {

             rock.GetComponent<Rigidbody>().useGravity = true;
             HasRock = false; //sets has rock to false
             IsHolding = false; // sets is holding to false 
             rockMesh.enabled = true; // enable this when player drops rock so it can be seen on ground
             rockCollider.enabled = true; // enable the collider so it can interact with anything in the world
         }
     }

     private void HoldingRock() // just going to call this when rock is placed in inventory
     {

         IsHolding = true; // sets is holding to true
     } */


    //When the mouse hovers over the GameObject, it turns to this color (red)
    Color m_MouseOverColor = Color.red;

    //This stores the GameObject’s original color
    Color m_OriginalColor;

    //Get the GameObject’s mesh renderer to access the GameObject’s material and color
    MeshRenderer m_Renderer;

    void Start()
    {
        //Fetch the mesh renderer component from the GameObject
        m_Renderer = GetComponent<MeshRenderer>();
        //Fetch the original color of the GameObject
        m_OriginalColor = m_Renderer.material.color;
    }

    void OnMouseOver()
    {
        // Change the color of the GameObject to red when the mouse is over GameObject
        m_Renderer.material.color = m_MouseOverColor;
        Debug.Log("Mouse is over GameObject.");
    }

    void OnMouseExit()
    {
        // Reset the color of the GameObject back to normal
        m_Renderer.material.color = m_OriginalColor;
        Debug.Log("Mouse is not over a GameObject.");
    }


}

