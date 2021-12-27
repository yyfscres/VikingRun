using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Rigidbody))]

public class EnemyBehavior : MonoBehaviour
{
    private Vector3 MovingDirection = Vector3.forward;
    public float JumpingForce = 10f;
    [SerializeField] public float movingSpeed = 10f;
    Rigidbody rb;
    public Animator animator;
    private bool turnleft, turnright;
    public Canvas canvas1;
    private bool grounded = false;
    public Text livetime,mushroomscore;
    public Text timenumber, MushroomScore;

    public int movingDirection = 1;
    public LayerMask whatisGround;


    bool onGround = false, run = false;
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

        Debug.Log(grounded);
        //turnleft = Input.GetKeyDown(KeyCode.Q);
        //turnright = Input.GetKeyDown(KeyCode.E);


        //transform.localPosition += movingSpeed * Time.deltaTime * MovingDirection;


        run = true;
        if (Input.GetKey(KeyCode.A))
        {
            if (movingDirection == 0)
            {
                transform.localPosition -= movingSpeed * Time.deltaTime * Vector3.back;
            }
            if (movingDirection == 1)
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.left;
            }
            if (movingDirection == 2)
            {
                transform.localPosition -= movingSpeed * Time.deltaTime * Vector3.forward;
            }
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            if (movingDirection == 0)
            {
                transform.localPosition -= movingSpeed * Time.deltaTime * Vector3.forward;
            }
            if (movingDirection == 1)
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.right;
            }
            if (movingDirection == 2)
            {
                transform.localPosition -= movingSpeed * Time.deltaTime * Vector3.back;
            }
        }

        run = true;
        
        if (turnleft && movingDirection > 0)
        {
            //transform.Rotate(new Vector3(0f, -90f, 0f));
            movingDirection -= 1;


        }
        if (turnright && movingDirection < 2)
        {
            //transform.Rotate(new Vector3(0f, 90f, 0f));
            movingDirection += 1;

        }
        /*
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
        */
        animator.SetBool("Run", run);


    }
    private void OnCollisionEnter(Collision collision)
    {
        

    }
    private void OnCollisionStay(Collision collision)
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Time.timeScale = 0f;
            livetime.text = "You had lived for " + timenumber.text + " seconds";
            mushroomscore.text = "You got " + MushroomScore.text + " mushroooms";
            canvas1.gameObject.SetActive(true);
        }
    }
}
