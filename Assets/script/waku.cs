using UnityEngine;

public class waku : MonoBehaviour
{
    public GameObject[] gaikotu;
    public GameObject[] hasonbox;
    public GameObject[] box;
    public GameObject[] takara;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < gaikotu.Length; i++) 
        {
            if (gaikotu[i] == player.hit) 
            {
                //anime
            }

        }
        for (int i = 0; i < hasonbox.Length; i++)
        {
            if (hasonbox[i] == player.hit)
            {
                //anime
            }
        }
        for (int i = 0; i < box.Length; i++)
        {
            if (box[i] == player.hit)
            {
                //anime
            }
        }
        for (int i = 0; i < takara.Length; i++)
        {
            if (takara[i] == player.hit)
            {
                //anime
            }
        }
        if (player.hit == null) 
        {
            //anime
        }
        transform.position = player.hit.transform.position;
    }
}
