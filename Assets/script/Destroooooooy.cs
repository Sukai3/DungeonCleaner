using UnityEngine;

public class Destroooooooy : MonoBehaviour
{
    private int scene = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scene = flag.scene;
        if (flag.clear[scene])
            Destroy(gameObject);
    }
}
