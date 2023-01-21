using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLog : MonoBehaviour
{
    public int time = 5;
    public bool isDead = true;
    public string myKey = "space";
    public float speed = 5.5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World from debug");
        Debug.LogWarning("This is a warning");
        Debug.LogError("something went wrong");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(myKey))
        {
            print("space was pressed");
        }
    }
}
