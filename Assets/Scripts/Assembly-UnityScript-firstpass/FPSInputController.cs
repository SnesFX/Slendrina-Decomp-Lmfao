using System;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class FPSInputController : MonoBehaviour
{
    private CharacterMotor motor;

    public GameObject footstepScriptHolder;

    public GameObject headBobAnimHolder;

    private Vector3 velocity;

    public float speed;

    public float jumpSpeed;

    public float gravity;

    public FPSInputController()
    {
        speed = 6f;
        jumpSpeed = 8f;
        gravity = 20f;
    }

    public virtual void Awake()
    {
        motor = (CharacterMotor)GetComponent(typeof(CharacterMotor));
    }

    public virtual void Update()
    {
        CharacterController component = GetComponent<CharacterController>();
        Vector3 direction = Vector3.zero; // initialize direction to a zero vector
        if (component.isGrounded)
        {
            direction = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            direction = transform.TransformDirection(direction);
            direction *= speed;
            if (direction != Vector3.zero)
            {
                headBobAnimHolder.GetComponent<Animation>().CrossFade("HeadBobAnimation");
                headBobAnimHolder.GetComponent<Animation>().Stop("playerIdle");
                UnityRuntimeServices.Invoke(footstepScriptHolder.GetComponent("Footsteps"), "walk", new object[0], typeof(MonoBehaviour));
            }
            else
            {
                headBobAnimHolder.GetComponent<Animation>().Stop("HeadBobAnimation");
                headBobAnimHolder.GetComponent<Animation>().CrossFade("playerIdle");
                UnityRuntimeServices.Invoke(footstepScriptHolder.GetComponent("Footsteps"), "stopwalk", new object[0], typeof(MonoBehaviour));
            }
        }
        direction.y -= gravity * Time.deltaTime;
        component.Move(direction * Time.deltaTime);
    }

    public virtual void Main()
    {
    }
}
