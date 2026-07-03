using UnityEngine;

public class okimono : MonoBehaviour
{

    public GameObject goal;
    private bool setti=false;
    public bool hantei=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(setti)
            transform.position = goal.transform.position;
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.CompareTag(TAG))
        //    Destroy(gameObject);
        if (collision.gameObject == goal)
        {
            setti = true;
            if (hantei)
                Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == goal)
        {
            setti = true;
            if (hantei)
                Destroy(gameObject);
            
        }
    }

}
