using UnityEngine;

public class arrow : MonoBehaviour
{
    public int bangoo;

    public int[] test;
    public bool exit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag.clear[flag.scene])
        {
            if(!exit) 
            {
                if (!flag.clear[bangoo])
                    GetComponent<SpriteRenderer>().enabled = true;
            }

            if (exit)
            {
                for(int i=0;i<test.Length;i++)
                if (!flag.clear[test[i]])
                    GetComponent<SpriteRenderer>().enabled = true;
            }
        }

    }
}
