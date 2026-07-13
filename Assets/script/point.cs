//using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UIElements;

public class point : MonoBehaviour
{
    public int iti;
    public int scene;
    public bool atatta;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            atatta = true;
            player.position = iti;
            SceneManager.LoadScene("stage" + scene);
        }
    }
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            atatta = true;
            player.position = iti;
            SceneManager.LoadScene("stage" + scene);
        }
    }

}



