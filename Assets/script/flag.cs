using UnityEngine;
using UnityEngine.UIElements;

public class flag : MonoBehaviour
{
    //public static bool[] clear = new bool[maxscene];
    public static bool[] clear;
    public int gomi=0;
    public int okimono=0;
    public bool kakunin;
    public static int scene=0;
    public int nowscene;
    public static int maxscene=40;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scene=nowscene;
        clear = new bool[maxscene];
    }

    // Update is called once per frame
    void Update()
    {
        if (gomi==0 && okimono==0)
            clear[scene] = true;
        kakunin = clear[scene];
        //kakuninscene=scene; 
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("gomi"))
        {
            gomi--;
        }
        if (collision.gameObject.CompareTag("okimono"))
        {
            okimono--;
        }

    }

}
