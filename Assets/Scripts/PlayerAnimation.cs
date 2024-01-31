using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    // References
    Animator am;
    PlayerMovement pm;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        am = GetComponent<Animator>();
        pm = GetComponent<PlayerMovement>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
         if (pm.moveDir.x != 0 || pm.moveDir.y != 0)
         {
            am.SetBool("Move", true);
            spriteDirectionChecker();
         }
         else
         {
            am.SetBool("Move", false);
         }
    }
    
    void spriteDirectionChecker()
    {
        if (pm.moveDir.x < 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX=false;
        }
    }
}
