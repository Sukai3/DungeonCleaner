using System;
using UnityEngine;

public class box : MonoBehaviour
{
    private float speedX = 0.02f;
    private float speedY = 0.02f;
    public float speedX2 = 0.02f;
    public float speedY2 = 0.02f;
    private bool x = false;
    private bool y = false;
    public bool wallright = false;
    public bool wallleft = false;
    public bool wallup = false;
    public bool walldown = false;
    Vector3 myt;
    Vector3 collt;
    private bool yoko = false;
    private bool tate = false;
    private bool me=false;

    private bool hantei=false;
    private float timer = 0.0f;
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(player.hit==gameObject)
            me = true;
        else
            me= false;

        if (hantei)
            timer += Time.deltaTime;
        else
            timer = 0.0f;
        if (timer > 0.3f&&timer<0.35f)
            player.hit = null;
        //transform.Translate(new Vector3(speedX, speedY, 0) * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow) && !y || (Input.GetKey(KeyCode.LeftArrow)) && !y)
        {

            x = true;
        }
        else { x = false; speedX = 0; }
        if (Input.GetKey(KeyCode.UpArrow) && !x || (Input.GetKey(KeyCode.DownArrow)) && !x)
            y = true;
        else { y = false; speedY = 0; }



        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.JoystickButton0)) 
        {
            if (yoko)
            {
                if ((Input.GetKey(KeyCode.LeftArrow) && !y) || (player.stickX == -1 && !y))
                {
                    speedX = -speedX2;
                    if (wallright || player.wallright||player.objleft)
                        speedX = 0;

                }
                if ((Input.GetKey(KeyCode.RightArrow) && !y) || (player.stickX == 1 && !y))
                {
                    speedX = speedX2;
                    if (wallleft || player.wallleft || player.objright)
                        speedX = 0; 
                }
                if ((Input.GetKey(KeyCode.RightArrow) && !y || (Input.GetKey(KeyCode.LeftArrow)) && !y) || (player.stickX != 0 && !y))
                {
                    x = true;
                }
                //else { x = false; speedX = 0; }
                if(me)
                transform.Translate(new Vector3(speedX, speedY, 0) * Time.deltaTime);
            }
            if (tate) 
            {

                if ((Input.GetKey(KeyCode.UpArrow) && !x) || (player.stickY == 1 && !x))
                {
                    speedY = speedY2;
                    y = true;
                    if (walldown || player.walldown || player.objup)
                        speedY = 0;
                }
                if ((Input.GetKey(KeyCode.DownArrow) && !x) || (player.stickY == -1 && !x))
                {
                    speedY = -speedY2;
                    y = true;
                    if (wallup || player.wallup || player.objdown)
                        speedY = 0;
                }
                if ((Input.GetKey(KeyCode.UpArrow) && !x || (Input.GetKey(KeyCode.DownArrow)) && !x) || (player.stickY != 0 && !x))
                    y = true;
                // else { y = false; speedY = 0; }
                if(me)
                transform.Translate(new Vector3(speedX, speedY, 0) * Time.deltaTime);

            }


        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKey(KeyCode.JoystickButton0))
        {
            { x = false; speedX = 0; y = false; speedY = 0; }
        }
        }
    void Move()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && !y)
        {
            speedX = -speedX2;

        }
        if (Input.GetKey(KeyCode.RightArrow) && !y)
        {
            speedX = speedX2;
        }
        if (Input.GetKey(KeyCode.RightArrow) && !y || (Input.GetKey(KeyCode.LeftArrow)) && !y)
        {
            x = true;
        }
        else { x = false; speedX = 0; }
        if (Input.GetKey(KeyCode.UpArrow) && !x)
        {
            speedY = speedY2;
            y = true;
        }
        if (Input.GetKey(KeyCode.DownArrow) && !x)
        {
            speedY = -speedY2;
            y = true;
        }
        if (Input.GetKey(KeyCode.UpArrow) && !x || (Input.GetKey(KeyCode.DownArrow)) && !x)
            y = true;
        else { y = false; speedY = 0; }
        //transform.position = new Vector3(posx, posy, 0);
        transform.Translate(new Vector3(speedX, speedY, 0) * Time.deltaTime);
    }
   
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wallright") || collision.gameObject.CompareTag("objright"))
            wallright = true;
        if (collision.gameObject.CompareTag("wallleft")|| collision.gameObject.CompareTag("objleft") )
            wallleft = true;
        if (collision.gameObject.CompareTag("wallup")  || collision.gameObject.CompareTag("objup")   )
            wallup = true;
        if (collision.gameObject.CompareTag("walldown")|| collision.gameObject.CompareTag("objdown") )
            walldown = true;


        if (collision.gameObject.CompareTag("left"))
        {
            if (me)
                player.objleft = false;
        }
        if((collision.gameObject.CompareTag("right")))
        {
            if (me)
                player.objright = false;
        }

        //    if (Input.GetKey(KeyCode.LeftShift))
        //{
        //    if (collision.gameObject.CompareTag("left") || collision.gameObject.CompareTag("right"))
        //    {


        //            if (Input.GetKey(KeyCode.LeftArrow) && !y)
        //            {
        //                speedX = -speedX2;
        //            if(wallright|| player.wallright)
        //                speedX = 0;

        //            }
        //            if (Input.GetKey(KeyCode.RightArrow) && !y )
        //            {
        //                speedX = speedX2;
        //            if (wallleft || player.wallleft)
        //                speedX= 0;
        //            }
        //            if (Input.GetKey(KeyCode.RightArrow) && !y || (Input.GetKey(KeyCode.LeftArrow)) && !y)
        //            {
        //                x = true;
        //            }
        //            //else { x = false; speedX = 0; }

        //            transform.Translate(new Vector3(speedX, speedY, 0) * Time.deltaTime);

        //    }

        //    if ((collision.gameObject.CompareTag("down") || collision.gameObject.CompareTag("up")) )
        //    {
        //        if (Input.GetKey(KeyCode.UpArrow) && !x )
        //        {
        //            speedY = speedY2;
        //            y = true;
        //            if (walldown || player.walldown)
        //                speedY = 0;
        //        }
        //        if (Input.GetKey(KeyCode.DownArrow) && !x)
        //        {
        //            speedY = -speedY2;
        //            y = true;
        //            if(wallup || player.wallup)
        //                speedY= 0;
        //        }
        //        if (Input.GetKey(KeyCode.UpArrow) && !x || (Input.GetKey(KeyCode.DownArrow)) && !x)
        //            y = true;
        //        // else { y = false; speedY = 0; }
        //        transform.Translate(new Vector3(speedX, speedY, 0) * Time.deltaTime);
        //    }
        //    // else { y = false; speedY = 0; }


        //}

        if (player.hit == null)
        {
            if (collision.gameObject.CompareTag("down") || collision.gameObject.CompareTag("up") || collision.gameObject.CompareTag("left") || collision.gameObject.CompareTag("right"))
            {
                hantei = false;
                timer = 0.0f;
                player.hit = gameObject;
            }
        }


    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("left") || collision.gameObject.CompareTag("right"))
        {
            yoko = true;

            if (collision.gameObject.CompareTag("left"))
            {
                if (me)
                    player.objleft = false;
            }
            else
            {
                if (me)
                    player.objright = false;
            }
        }
        if ((collision.gameObject.CompareTag("down") || collision.gameObject.CompareTag("up")))
        {
            tate = true;
            if (collision.gameObject.CompareTag("down"))
            {
                if (me)
                    player.objdown = false;
            }
            else
            {
                if (me)
                    player.objup = false ;
            }
        }
        

        //if ((player.a.CompareTag("left") || player.a.CompareTag("right") || player.a.CompareTag("up") || player.a.CompareTag("down") || player.a.CompareTag("Player")) )
        //{
        //    player.hit = gameObject;
        //}

    }
    void OnTriggerExit2D(Collider2D collision)
    {

        if ((collision.gameObject.CompareTag("left") || collision.gameObject.CompareTag("right") || collision.gameObject.CompareTag("down") || collision.gameObject.CompareTag("up")) &&gameObject==player.hit)
        {
            hantei = true;
            //player.hit = null;
        }

        //if (collision.gameObject.CompareTag("wall"))
        //{

        //    wallright = false;
        //    wallleft = false;
        //    walldown = false;
        //    wallup = false;
        //    { x = false; speedX = 0; y = false; speedY = 0; }
        //}
        if (collision.gameObject.CompareTag("wallright") || collision.gameObject.CompareTag("objright"))
            wallright = false;
        if (collision.gameObject.CompareTag("wallleft")|| collision.gameObject.CompareTag("objleft") )
            wallleft = false;
        if (collision.gameObject.CompareTag("wallup")  || collision.gameObject.CompareTag("objup")   )
            wallup = false;
        if (collision.gameObject.CompareTag("walldown")|| collision.gameObject.CompareTag("objdown") )
            walldown = false;


        if (collision.gameObject.CompareTag("left") || collision.gameObject.CompareTag("right"))
            yoko = false;
        if ((collision.gameObject.CompareTag("down") || collision.gameObject.CompareTag("up")))
            tate = false;

    }
}
