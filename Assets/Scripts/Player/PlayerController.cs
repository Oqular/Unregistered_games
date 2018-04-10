using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public PlayerClasses playerClass;

    private CharacterController controller;
    Rigidbody rigidBody;
    public float gravityScale;
    private Vector3 moveDir;
    private Vector3 dashDir;
    [SerializeField]
    private bool isInvulnerable;

    public float timer;

    MouseRayCast targetPos;

    private void Start()
    {
        isInvulnerable = false;
        moveDir = Vector3.zero;
        dashDir = Vector3.zero;
        controller = GetComponent<CharacterController>();
        rigidBody = GetComponent<Rigidbody>();
        targetPos = GameObject.FindObjectOfType<MouseRayCast>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //StartCoroutine(dashTimer(timer));
            Dash();
        }

        if (!isInvulnerable)
        {
            moveDir = new Vector3(Input.GetAxis("Horizontal") * playerClass.movementSpeed, 0f, Input.GetAxis("Vertical") * playerClass.movementSpeed);
            moveDir.y = moveDir.y + (Physics.gravity.y * gravityScale);
            dashDir = moveDir;
            controller.Move(moveDir * Time.deltaTime);
        }else
        {
            //Dash();
        }
        

    }

    void Dash()
    {

        rigidBody.AddForce((targetPos.hit.point) * 50, ForceMode.Impulse);

    }

    //IEnumerator dashTimer(float seconds)
    //{
    //    isInvulnerable = true;
    //    yield return new WaitForSeconds(seconds);
    //    isInvulnerable = false;
        
    //}

    //private void Dash()
    //{
    //    this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
    //}

}
