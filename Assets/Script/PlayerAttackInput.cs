using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackInput : MonoBehaviour
{
    private CharacterAnimation playerAnimation;

    private void Awake()
    {
        playerAnimation = GetComponent<CharacterAnimation>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.J))
        {
            playerAnimation.Defend(true);
        }
        if(Input.GetKeyDown(KeyCode.J))
        {
            playerAnimation.Defend(false);
        }
        if(Input.GetKey(KeyCode.K))
        {
            if(Random.Range(0,2)>0)
            {
                playerAnimation.Attack_1();
            }
            else
            {
                playerAnimation.Attack_2();
            }
        }
    }
}
