using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DemoCont : MonoBehaviour
{
    [Range(1, 10)]
    public float jumpVelocity;
    
    public float MoveSpeed =2.5f;
    public float rotateSpeed;
    public Rigidbody rb;
    public Animator anim;
    public Camera Cam;
    //public Collider GhostMode;
    public GameObject ScareMan;
    public GameObject GhostSphere;
    public LineRenderer GhostStream;

    Vector3 DestPos;
    private Vector3 MoveDir;
    private Vector3 destinationPos;
    Vector3 mousePosScreen;
    Vector3 mousePosWorld;
    public float GravityScale;
    public bool isPossessing;
    public ParticleSystem Possession;
    Vector3 forwardDirection;
    Vector3 rightDirection;


    // Start is called before the first frame update
    void Start()
    {
        
        anim = GetComponent<Animator>();
        destinationPos = transform.position;
        //GhostMode = this.GetComponent<Collider>();
        DestPos = transform.position;
        ScareMan = GameObject.FindGameObjectWithTag("ScareManager");
        GhostStream = GetComponent<LineRenderer>();
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


       
        //mousePosScreen = Input.mousePosition;
        //mousePosScreen.z = Camera.main.transform.position.z;
        //mousePosWorld = Camera.main.ScreenToWorldPoint(mousePosScreen);
       


        if (isPossessing != true)
        {
            Movement();
            Possession.Stop();

        }

        //else if (isPossessing == true)
        //{
        //    transform.position = Vector3.Lerp(this.transform.position, new Vector3(mousePosWorld.x,this.transform.position.y,mousePosWorld.z), 0.05f * Time.deltaTime);
        //}

    }

    void Movement()
    {
        

        MoveDir = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        MoveDir.y = MoveDir.y + (Physics.gravity.y * GravityScale);

        Vector3 rightMovement = rightDirection * MoveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        Vector3 upMovement = forwardDirection * MoveSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        
        transform.position += rightMovement;
        transform.position += upMovement;
        Vector3 groudPos = transform.position;
        groudPos.y = 2;
        transform.position = Vector3.MoveTowards(transform.position, groudPos, 0.5f*Time.deltaTime);

        

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(MoveDir.x, 0, MoveDir.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotateSpeed * Time.deltaTime);
        }

    }
    //highlight here.

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            MoveSpeed = 1f;
            print("WALLLL!");
        }

       
       

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            MoveSpeed = 2.5f;
            print("WALLLL!");
        }

        if (other.gameObject.tag == "Objects")
        {
            print("colliding");
           
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Objects")
        {
            print("GhostBaby");
           
         
        }
       


    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            MoveSpeed = 0.5f;
            

        }
    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Objects")
        {
            
        }
        if (collision.gameObject.tag == "Wall")
        {
            MoveSpeed = 2;

        }
    }



}
