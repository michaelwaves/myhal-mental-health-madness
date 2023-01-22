using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuObjects : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    private void Awake()
    {
        speed = Random.Range(2, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
        transform.Rotate(0, 0, -speed *36* Time.deltaTime, Space.World);
      
    }
}
