using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Rigidbody))]

public class NewBehaviourScript : MonoBehaviour
{
    private Vector3 MovingDirection = Vector3.forward;
    public float JumpingForce = 10f;
    [SerializeField] public float movingSpeed = 5f;
    Rigidbody rb;
    public Animator animator;
    public GameObject eatMusic;
    private float timer = 5.0f;

    private bool turnleft, turnright;
    public Transform groundCheck;
    private bool grounded=false;
    public int MushroomScore = 0;
    public Text muschroomText;
    public int movingDirection = 1;
    public LayerMask whatisGround;
    public Canvas canvas1;
    public Text livetime,mushroomscore,timenumber;
    
    private bool finishgame = true;
    

    bool onGround = false,run = false;
    // Start is called before the first frame update
    void Awake() //程式一開始裡面所有的東西都會被執行
    {
        Debug.Log("awake");
    }
    void Start() //會不會使用決定於是不是enable //initial
    {
        canvas1.gameObject.SetActive(false);

        //Debug.Log("start");
        //Transform t = GetComponent<Transform>();

        //t.position = Vector3.one;
        rb = GetComponent<Rigidbody>();
        //transform.position = Vector3.one;
 
        
    }


    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            movingSpeed = 5f;
        }
        
        Debug.Log(grounded);
        turnleft = Input.GetKeyDown(KeyCode.Q);
        turnright = Input.GetKeyDown(KeyCode.E);


        //transform.localPosition += movingSpeed * Time.deltaTime * MovingDirection;
        if (Input.GetKey(KeyCode.A))
        {
            if (movingDirection == 0)
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.back;
                
               
            }
            if (movingDirection == 1)
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.left;
            }
            if (movingDirection == 2)
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.forward;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (movingDirection == 0)
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.forward;
            }
            if (movingDirection == 1)
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.right;
            }
            if (movingDirection == 2)
            {
                transform.localPosition += movingSpeed * Time.deltaTime * Vector3.back;
            }
        }

        run = true;

        if (turnleft && movingDirection >0)
        {
            transform.Rotate(new Vector3(0f, -90f, 0f));
            movingDirection -=1;
            
            
        }
        if (turnright && movingDirection<2)
        {
            transform.Rotate(new Vector3(0f, 90f, 0f));
            movingDirection +=1;
            
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




        Debug.Log(grounded+"YES");
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(JumpingForce * Vector3.up,ForceMode.Impulse);
            grounded = false;
        }
        
        
        animator.SetBool("Run", run);

        if (this.gameObject.transform.position.y < -1 && finishgame)
        {
            Time.timeScale = 0f;
            livetime.text = "You had lived for "+timenumber.text+" seconds";
            mushroomscore.text = "You got " + MushroomScore.ToString() + " mushroooms";
            canvas1.gameObject.SetActive(true);
            
            
            finishgame = false;
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag==("Floor") && grounded == false)
        {
            grounded = true;
        }
        
        if (collision.gameObject.tag == ("Mushroom1"))
        {
            Instantiate(eatMusic, Vector3.zero, Quaternion.identity);
            MushroomScore += 1;
            Destroy(collision.gameObject);
            muschroomText.text = MushroomScore.ToString();
        }
        if (collision.gameObject.tag == ("Mushroom2"))
        {
            Instantiate(eatMusic, Vector3.zero, Quaternion.identity);
            MushroomScore += 2;
            Destroy(collision.gameObject);
            muschroomText.text = MushroomScore.ToString();
        }
        if (collision.gameObject.tag == ("Mushroom3"))
        {
            Instantiate(eatMusic, Vector3.zero, Quaternion.identity);
            MushroomScore += 3;
            Destroy(collision.gameObject);
            muschroomText.text = MushroomScore.ToString();
        }
        if (collision.gameObject.tag == ("Diamond"))
        {
            timer = 5.0f;
            Instantiate(eatMusic, Vector3.zero, Quaternion.identity);
            movingSpeed = 10f;
            Destroy(collision.gameObject);
            muschroomText.text = MushroomScore.ToString();
        }

    }

    private void OnCollisionStay(Collision collision)
    {
        
    }
  
}
