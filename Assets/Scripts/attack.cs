using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2f, 2f);
        float y = Random.Range(3.0f, 5.0f);
        float size = Random.Range(0.5f, 2.0f);

        transform.position = new Vector3(x, y, 0);
        transform.localScale = new Vector3(size, size, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }   
    }
}
