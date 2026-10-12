
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class waku : MonoBehaviour
{
    public GameObject[] gaikotu;
    public GameObject[] hasonbox;
    public GameObject[] box;
    public GameObject[] takara;
    public GameObject[] kan;
    private Animator anim;
    private float scax;
    private float scay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        scax = transform.localScale.x;
        scay = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {

        if (player.hit == null)
        {
            //anime
            //  anim.SetTrigger("empty");
            transform.localScale = new(scax, scay, transform.localScale.z);
            GetComponent<SpriteRenderer>().enabled = false;
            anim.SetBool("Gaikotub", false);
            anim.SetBool("Hboxb", false);
            anim.SetBool("Boxb", false);
            anim.SetBool("Takarab", false);
            anim.SetBool("Enptyb", true);
            anim.SetBool("Kanb", false);
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = true;
            transform.position = player.hit.transform.position;
        }


        for (int i = 0; i < gaikotu.Length; i++)
        {
            if (gaikotu[i] == player.hit)
            {
                transform.localScale = new(scax , scay , transform.localScale.z);
                //anime
                anim.SetTrigger("Gaikotu");
                anim.SetBool("Gaikotub",true);
                anim.SetBool("Hbox",false);
                anim.SetBool("Boxb",false);
                anim.SetBool("Takarab",false);
                anim.SetBool("Enptyb",false);
                anim.SetBool("Kanb", false);

            }
            
        }
        
        for (int i = 0; i < hasonbox.Length; i++)
        {
            if (hasonbox[i] == player.hit)
            {
                //anime
                //anim.SetTrigger("Hbox");
                transform.localScale = new(scax, scay, transform.localScale.z);
                anim.SetBool("Gaikotub", false);
                anim.SetBool("Hboxb", true);
                anim.SetBool("Boxb", false);
                anim.SetBool("Takarab", false);
                anim.SetBool("Enptyb", false);
                anim.SetBool("Kanb", false);
            }
        }
        for (int i = 0; i < box.Length; i++)
        {
            if (box[i] == player.hit)
            {
                //anime
                transform.localScale = new(scax, scay, transform.localScale.z);
                anim.SetTrigger("Box");
                anim.SetBool("Gaikotub", false);
                anim.SetBool("Hboxb", false);
                anim.SetBool("Boxb", true);
                anim.SetBool("Takarab", false);
                anim.SetBool("Enptyb", false);
                anim.SetBool("Kanb", false);
            }
        }
       
            for (int i = 0; i < takara.Length; i++)
            {
                if (takara[i] == player.hit)
                {
                //anime
                transform.localScale = new(scax*1.3f,scay*1.5f,transform.localScale.z);
                    anim.SetTrigger("takara");
                anim.SetBool("Gaikotub", false);
                anim.SetBool("Hboxb", false);
                anim.SetBool("Boxb", false);
                anim.SetBool("Takarab", true);
                anim.SetBool("Enptyb", false);
                anim.SetBool("Kanb", false);
            }
            }
        for (int i = 0; i < kan.Length; i++)
        {
            if (kan[i] == player.hit)
            {
                //anime
                transform.position = new Vector3(player.hit.transform.position.x, player.hit.transform.position.y - 1.0f, transform.position.z); ;

                transform.localScale = new(scax, scay, transform.localScale.z);
                anim.SetTrigger("takara");
                anim.SetBool("Gaikotub", false);
                anim.SetBool("Hboxb", false);
                anim.SetBool("Boxb", false);
                anim.SetBool("Takarab", false);
                anim.SetBool("Kanb", true);
                anim.SetBool("Enptyb", false);
            }
        }

      
    }
}
