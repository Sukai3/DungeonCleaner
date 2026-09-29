using UnityEngine;

public class waku : MonoBehaviour
{
    public GameObject[] gaikotu;
    public GameObject[] hasonbox;
    public GameObject[] box;
    public GameObject[] takara;
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
        for (int i = 0; i < gaikotu.Length; i++)
        {
            if (gaikotu[i] == player.hit)
            {
                //anime
                anim.SetTrigger("Gaikotu");
                anim.SetBool("Gaikotub",true);
                anim.SetBool("Hbox",false);
                anim.SetBool("Boxb",false);
                anim.SetBool("Takarab",false);
             
            }

        }
        
        for (int i = 0; i < hasonbox.Length; i++)
        {
            if (hasonbox[i] == player.hit)
            {
                //anime
                anim.SetTrigger("Hbox");
                anim.SetBool("Gaikotub", false);
                anim.SetBool("Hbox", true);
                anim.SetBool("Boxb", false);
                anim.SetBool("Takarab", false);
            }
        }
        for (int i = 0; i < box.Length; i++)
        {
            if (box[i] == player.hit)
            {
                //anime
                anim.SetTrigger("Box");
                anim.SetBool("Gaikotub", false);
                anim.SetBool("Hbox", false);
                anim.SetBool("Boxb", true);
                anim.SetBool("Takarab", false);
            }
        }
       
            for (int i = 0; i < takara.Length; i++)
            {
                if (takara[i] == player.hit)
                {
                    //anime
                    anim.SetTrigger("takara");
                anim.SetBool("Gaikotub", false);
                anim.SetBool("Hbox", false);
                anim.SetBool("Boxb", false);
                anim.SetBool("Takarab", true);
            }
            }
        
        if (player.hit == null) 
        {
            //anime
            anim.SetTrigger("empty");
            anim.SetBool("Gaikotub", false);
            anim.SetBool("Hbox", false);
            anim.SetBool("Boxb", false);
            anim.SetBool("Takarab", false);
        }
        else
        transform.position = player.hit.transform.position;
    }
}
