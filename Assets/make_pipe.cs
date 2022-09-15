using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class make_pipe : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pipe;
    float timer = 0;
    public float time_delay;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > time_delay)
        {
            GameObject new_pipe = Instantiate(pipe);
            new_pipe.transform.position = new Vector3(5, Random.Range(0.0f, 3.5f), 0);
            Destroy(new_pipe, 5.0f);
            timer = 0;

        }
       

    }
}
