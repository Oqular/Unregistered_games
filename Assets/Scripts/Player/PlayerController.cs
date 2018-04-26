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
    public bool isInvulnerable;

    public float timer;

    MouseRayCast targetPos;

    private Camera mainCamera;
    public Plane ground;
    public Gun gun;
    public static Vector3 pointToLook;

    private void Start()
    {
        isInvulnerable = false;
        moveDir = Vector3.zero;
        dashDir = Vector3.zero;
        controller = GetComponent<CharacterController>();
        rigidBody = GetComponent<Rigidbody>();
        targetPos = GameObject.FindObjectOfType<MouseRayCast>();
        mainCamera = FindObjectOfType<Camera>();
    }

    private void Update()
    {

        moveDir = new Vector3(Input.GetAxis("Horizontal") * playerClass.movementSpeed, 0f, Input.GetAxis("Vertical") * playerClass.movementSpeed);
        moveDir.y = moveDir.y + (Physics.gravity.y * gravityScale);
        dashDir = moveDir;
        controller.Move(moveDir * Time.deltaTime);

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            //StartCoroutine(dashTimer(timer));
            Dash();
        }*/

        if (!isInvulnerable)
        {
            
        }else
        {
            //Dash();
        }
        //--------------------------------------------------------------------------
        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane imaginaryPlane = new Plane(Vector3.up, new Vector3(0, transform.position.y, 0));
        float rayLenght;
        if (imaginaryPlane.Raycast(cameraRay, out rayLenght))
        {
            pointToLook = cameraRay.GetPoint(rayLenght);
            Debug.DrawLine(cameraRay.origin, pointToLook, Color.red);
            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
            //transform.LookAt(pointToLook);
        }

        if (Input.GetMouseButtonDown(0))
        {
            gun.isFiring = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            gun.isFiring = false;
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
