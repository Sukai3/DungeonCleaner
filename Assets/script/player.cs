using UnityEditor;
using UnityEngine;

public class player : MonoBehaviour
{
    float posx = 0;
    float posy=0;
    public float speedX = 0.02f;
    public float speedY=0.02f;
    public float speedX2 = 0.02f;
    public float speedY2 = 0.02f;
    bool x=false;
    bool y=false;
    public static bool wallright = false;
    public static bool wallleft = false;
    public static bool wallup = false;
    public static bool walldown = false;
    public static int position=0;
    public GameObject[] point;
    public static float stickX;
    public static float stickY;
    private float horizontal;
    public static GameObject hit;
    public  GameObject hitkakunin;
    public static bool objright = false;
    public static bool objleft = false;
    public static bool objup = false;
    public static bool objdown = false;
    public bool objkakuninR = false;
    private int cont = 1;

    private Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        wallright = false;
        wallleft = false;
        wallup = false;
        walldown = false;
        transform.position = point[position].transform.position;
        hit = null;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        hitkakunin = hit;
        objkakuninR = wallright;

        if (Input.GetKeyDown(KeyCode.Space))
            cont *= -1;

    }

    void Move()
    {
        if (cont == -1)
        {
            if (Input.GetAxis("Horizontal") < -0.5)//Vertical
            {

                stickX = -1;
            }
            if (Input.GetAxis("Horizontal") > 0.5)
            {
                stickX = 1;
            }
            if (Input.GetAxis("Horizontal") > -0.4 && Input.GetAxis("Horizontal") < 0.4)
            {
                stickX = 0;
            }


            if (Input.GetAxis("Vertical") < -0.5)//Vertical
            {

                stickY = -1;
            }
            if (Input.GetAxis("Vertical") > 0.5)
            {
                stickY = 1;
            }
            if (Input.GetAxis("Vertical") > -0.4 && Input.GetAxis("Vertical") < 0.4)
            {
                stickY = 0;
            }

        }
        else 
        {
            stickX = 0;
            stickY= 0;
        }


        if ((Input.GetKey(KeyCode.LeftArrow) && !y)|| (stickX==-1 && !y))
        {
            anim.SetBool("left", true);
            anim.SetBool("up", false);
            anim.SetBool("down", false);
            anim.SetBool("right", false);
            speedX = -speedX2;
            if (wallright || objright)
                speedX = 0;

        }
        if ((Input.GetKey(KeyCode.RightArrow) && !y) || (stickX==1 && !y))
        {
            anim.SetBool("left", false);
            anim.SetBool("up", false);
            anim.SetBool("down", false);
            anim.SetBool("right", true);
            speedX = speedX2;
            if (wallleft || objleft)
                speedX = 0;

        }
        if ((Input.GetKey(KeyCode.RightArrow) && !y || (Input.GetKey(KeyCode.LeftArrow)) && !y)||(stickX!=0&&!y))
        {
            x = true;
        }
        else { x = false; speedX = 0; }
        if ((Input.GetKey(KeyCode.UpArrow) && !x)||(stickY==1&&!x))
        {
            anim.SetBool("left", false);
            anim.SetBool("up", true);
            anim.SetBool("down", false);
            anim.SetBool("right", false);
            speedY = speedY2;
            y = true;
            if (walldown||objdown)
                speedY = 0;

        }
        if ((Input.GetKey(KeyCode.DownArrow) && !x) || (stickY == -1 && !x))
        {
            anim.SetBool("left", false);
            anim.SetBool("up", false);
            anim.SetBool("down", true);
            anim.SetBool("right", false);
            speedY = -speedY2;
            y = true;
            if (wallup||objup)
                speedY = 0;

        }
        if ((Input.GetKey(KeyCode.UpArrow) && !x || (Input.GetKey(KeyCode.DownArrow)) && !x) || (stickY != 0 && !x))
            y = true;
        else { y = false; speedY = 0; }
        //transform.position = new Vector3(posx, posy, 0);
        transform.Translate(new Vector3(speedX, speedY, 0) * Time.deltaTime);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("wallright") && hit != collision.gameObject)
            wallright = true;
        if (collision.gameObject.CompareTag("wallleft") && hit != collision.gameObject )
            wallleft = true;
        if (collision.gameObject.CompareTag("wallup") && hit != collision.gameObject   )
            wallup = true;
        if (collision.gameObject.CompareTag("walldown") && hit != collision.gameObject )
            walldown = true;

       

    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{

        
    //    if (collision.gameObject.CompareTag("tukami") && hit == null)
    //    {
    //        hit = collision.gameObject;
    //    }
    //}

    void OnTriggerExit2D(Collider2D collision)
    {
       
        if (collision.gameObject.CompareTag("wallright") && hit != collision.gameObject)
            wallright = false;
        if (collision.gameObject.CompareTag("wallleft") && hit != collision.gameObject)
            wallleft = false;
        if (collision.gameObject.CompareTag("wallup") && hit != collision.gameObject)
            wallup = false;
        if (collision.gameObject.CompareTag("walldown") && hit != collision.gameObject)
            walldown = false;


       
        //if (collision.gameObject.CompareTag("tukami"))
        //{
        //    hit = null;
        //}

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("boxright"))
            objright = true;
        if (collision.gameObject.CompareTag("boxleft"))
            objleft = true;
        if (collision.gameObject.CompareTag("boxup"))
            objup = true;
        if (collision.gameObject.CompareTag("boxdown"))
            objdown = true;
    }


    //    if (collision.gameObject.CompareTag("tukami") && hit == null)
    //    {
    //        hit = collision.gameObject;
    //    }

    //}
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("boxright"))
            objright = false;
        if (collision.gameObject.CompareTag("boxleft"))
            objleft = false;
        if (collision.gameObject.CompareTag("boxup"))
            objup = false;
        if (collision.gameObject.CompareTag("boxdown"))
            objdown = false;
    }

        //    if (collision.gameObject.CompareTag("tukami"))
        //    {
        //        hit = null;
        //    }
        //}
    }
