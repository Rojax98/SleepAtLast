using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [Range(1, 10)]
    public float jumpVelocity;

    public float MoveSpeed = 2.5f;
    public float rotateSpeed;
    public Rigidbody rb;
    public Animator anim;
    public Camera Cam;
    //public Collider GhostMode;
  

    Vector3 DestPos;
    private Vector3 MoveDir;
    private Vector3 destinationPos;
    Vector3 mousePosScreen;
    Vector3 mousePosWorld;
    public float GravityScale;
    public bool hasLight;
   
    Vector3 forwardDirection;
    Vector3 rightDirection;


    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        destinationPos = transform.position;
        //GhostMode = this.GetComponent<Collider>();
        DestPos = transform.position;
      
        rb = this.GetComponent<Rigidbody>();

        forwardDirection = Camera.main.transform.forward;
        forwardDirection.y = 0;
        forwardDirection = forwardDirection.normalized;

        rightDirection = Camera.main.transform.right;
        rightDirection.y = 0;
        rightDirection = rightDirection.normalized;

    }

    // Update is called once per frame
    void Update()
    {



     



        
            Movement();
           

        

       

    }

    void Movement()
    {


        MoveDir = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        MoveDir.y = MoveDir.y + (Physics.gravity.y * GravityScale);

        Vector3 rightMovement = rightDirection * MoveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        Vector3 upMovement = forwardDirection * MoveSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        transform.forward = heading;
        transform.position += rightMovement;
        transform.position += upMovement;
        
        

        anim.SetFloat("Speed", (Mathf.Abs(Input.GetAxis("Horizontal")) + Mathf.Abs(Input.GetAxis("Vertical"))));

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(MoveDir.x, 0, MoveDir.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotateSpeed * Time.deltaTime);
        }

    }
    //highlight here.

    private void OnTriggerEnter(Collider other)
    {
      




    }

    private void OnTriggerExit(Collider other)
    {
        
     
    }

    private void OnCollisionEnter(Collision collision)
    {
     



    }

    private void OnCollisionStay(Collision collision)
    {
     
    }


    private void OnCollisionExit(Collision collision)
    {
       
    }



}
