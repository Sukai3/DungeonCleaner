using UnityEngine;
using UnityEngine.SceneManagement;

public class Mscenchange : MonoBehaviour
{
    public string next;
    public int test;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.JoystickButton0)|| Input.GetKeyDown(KeyCode.A))
        {
            player.position = test;
            SceneManager.LoadScene(next);
        }
    }
}
