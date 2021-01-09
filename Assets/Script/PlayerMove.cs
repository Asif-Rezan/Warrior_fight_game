using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private CharacterController charController;
    public float movement_speed=3f;
    public float gravity = 9.8f;
    public float rotation_speed = 0.15f;
    public float roatetDegreePerSecond = 180f;

    private CharacterAnimation playerAnimation;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
        playerAnimation = GetComponent<CharacterAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
        AnimateWalk();
    }
    void Move()
    {
        if(Input.GetAxis(Axis.VERTICAL_AXIS)>0)
        {
            Vector3 movedirection = transform.forward;
            movedirection.y -= gravity * Time.deltaTime;
            charController.Move(movedirection * movement_speed * Time.deltaTime);
        }
        else if(Input.GetAxis(Axis.VERTICAL_AXIS)<0)
        {
            Vector3 movedirection = -transform.forward;
            movedirection.y -= gravity * Time.deltaTime;
            charController.Move(movedirection * movement_speed * Time.deltaTime);
        }
        else
        {
            charController.Move(Vector3.zero);
        }

    }

    void Rotate()
    {
        Vector3 rotaionDiraction = Vector3.zero;

        if(Input.GetAxis(Axis.Horijontal_AXIS)<0)
        {
            rotaionDiraction = transform.TransformDirection(Vector3.left);
        }
        if(Input.GetAxis(Axis.Horijontal_AXIS)>0)
        {
            rotaionDiraction = transform.TransformDirection(Vector3.right);
        }
        if(rotaionDiraction!=Vector3.zero)
        {
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation, Quaternion.LookRotation(rotaionDiraction), roatetDegreePerSecond * Time.deltaTime);
        }
    }



    void AnimateWalk()
    {
        if (charController.velocity.sqrMagnitude!=0f)
        {
            playerAnimation.Walk(true);
        }
        else
        {
            playerAnimation.Walk(false);
        }
    }
    
}