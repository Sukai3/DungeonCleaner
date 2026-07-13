using UnityEngine;
using UnityEngine.SceneManagement;
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
    public static int a=0;
    public  static int b=0;
    private  int i=0;
    public static float timer=0;
    public float time=3;
    public int max=5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scene=nowscene;
        if(a==0)
        clear = new bool[maxscene];
        
      
        
    }

    // Update is called once per frame
    void Update()
    {
        a = 1;
        if (gomi == 0 && okimono == 0&&i==0)
        {
            b++;
            i++;
            clear[scene] = true;
        }
        kakunin = clear[scene];

        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene("stage"+nowscene);
        //kakuninscene=scene; 

        if (b==max) 
        {
            timer += Time.deltaTime;
        }
        if(timer>time)
            SceneManager.LoadScene("clearScene");
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
