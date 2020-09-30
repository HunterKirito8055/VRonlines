using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrMove : MonoBehaviour
{
    bool isClicked;
    public float SpeedMove = 1.5f;
    bool isPlayerRotate = true;
    bool isrotate;
    CharacterController player;

    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            isClicked = !isClicked;
            isPlayerRotate = !isPlayerRotate;
        }
        Move();
    }

    void Move()
    {
        if(isClicked && !isPlayerRotate)
        {
            Vector3 di = Camera.main.transform.forward * SpeedMove;
            player.SimpleMove(di);
        }
        
        float h = Input.GetAxis("Horizontal");
        if (isPlayerRotate) // player can now move
        {
            if (h>0 && isrotate)
            {
            
                    transform.Rotate(Vector3.up, 45f );
                    isrotate = false;
                
            }
            else if (h < 0 && isrotate)  
            {
                    transform.Rotate(Vector3.up, -45f );
                    isrotate = false;
             
            }  
            else if (h==0 && !isClicked)
            {
                isrotate = true;
            }
        }
    }
   
}
