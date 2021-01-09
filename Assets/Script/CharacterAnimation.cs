using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{

    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        
    }

    public void Walk(bool walk)
    {
        anim.SetBool(AnimationTags.Walk_Parameter, walk);
    }
    public void Defend(bool defend)
    {
        anim.SetBool(AnimationTags.Defence_Parameter, defend);
    }
    public void Attack_1()
    {
        anim.SetTrigger(AnimationTags.Attack1_Trigger);
    }
    public void Attack_2()
    {
        anim.SetTrigger(AnimationTags.Attack2_Trigger);
    }




}
