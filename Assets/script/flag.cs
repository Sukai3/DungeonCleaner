using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;


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

    public AudioClip soundgomi;
    public AudioClip soundoki;
    AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scene=nowscene;
        if(a==0)
        clear = new bool[maxscene];
        audioSource = GetComponent<AudioSource>();


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

        if (Input.GetKeyDown(KeyCode.R)|| Input.GetKeyDown(KeyCode.JoystickButton6))
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
            audioSource.PlayOneShot(soundgomi);
        }
        if (collision.gameObject.CompareTag("okimono"))
        {
            okimono--;
            audioSource.PlayOneShot(soundoki);
        }

    }

}
