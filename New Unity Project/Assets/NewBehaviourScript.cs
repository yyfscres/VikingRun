using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class NewBehaviourScript : MonoBehaviour
{
    private Vector3 MovingDirection = Vector3.forward;
    public float JumpingForce = 10f;
    [SerializeField] public float movingSpeed = 10f;
    Rigidbody rb;
    public Animator animator;
    private bool turnleft, turnright;

    public int movingDirection = 1;


    bool onGround = false,run = false;
    // Start is called before the first frame update
    void Awake() //程式一開始裡面所有的東西都會被執行
    {
        Debug.Log("awake");
    }
    void Start() //會不會使用決定於是不是enable //initial
    {

        //Debug.Log("start");
        //Transform t = GetComponent<Transform>();

        //t.position = Vector3.one;
        rb = GetComponent<Rigidbody>();
        //transform.position = Vector3.one;
 
        
    }


    // Update is called once per frame
    void Update()
    {
        turnleft = Input.GetKeyDown(KeyCode.A);
        turnright = Input.GetKeyDown(KeyCode.D);


        //transform.localPosition += movingSpeed * Time.deltaTime * MovingDirection;


        run = true;

        if (turnleft)
        {
            transform.Rotate(new Vector3(0f, -90f, 0f));
            movingDirection -= 1;
            
            
        }
        if (turnright)
        {
            transform.Rotate(new Vector3(0f, 90f, 0f));
            movingDirection += 1;
            
        }
        switch (movingDirection)
        {
            case 1:
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.forward;
                break;
            case 0:
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.left;
                break;
            case 2:
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.right;
                break;
        }
        
            
        
      
        
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(JumpingForce * Vector3.up);
        }
        
        
        animator.SetBool("Run", run);
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.name);
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }
  
}
