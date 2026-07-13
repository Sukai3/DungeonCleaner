using UnityEngine;
using UnityEngine.SceneManagement;

public class Mscenchange : MonoBehaviour
{
    public string next;
    public int test;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flag.a = 0;
        flag.b = 0;
        flag.timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.A))
        {
            player.cont = 1;
            player.position = test;
            SceneManager.LoadScene(next);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton0)) 
        {
            player.cont = -1;
            player.position = test;
            SceneManager.LoadScene(next);
        }
    }
}
