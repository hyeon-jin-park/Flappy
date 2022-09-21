using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public static int Score = 0;
    public static int bestScore = 0;
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = Score.ToString();
    }
}
