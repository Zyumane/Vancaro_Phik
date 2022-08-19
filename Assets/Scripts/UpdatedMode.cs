using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatedMode : MonoBehaviour
{
    [SerializeField] protected float _objSpeed = 10f;
    [SerializeField] protected float _objMultiplier = 10f;

    protected Rigidbody objRigidBody;
    protected Vector3 movementForce;
    protected bool jupingAct;

    private void Awake()
    {
        objRigidBody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        movementForce = new Vector3(x: Horizontal, y: 0f, z: Vertical);

        if (Input.GetButtonDown("Fire1") && isGround())
        {
            jupingAct = true;
        }
    }

    private bool isGround() => true;

    void FixedUpdate()
    {
        MoveBody();
        JumpBody();
    }

    void MoveBody()
    {
        objRigidBody.AddForce(movementForce * _objSpeed);
    }

    void JumpBody()
    {
        if (jupingAct)
        {
            objRigidBody.AddForce(Vector3.up * _objMultiplier);
            jupingAct = false;
        }
    }
}
