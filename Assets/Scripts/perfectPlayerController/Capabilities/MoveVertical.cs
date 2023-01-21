using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVertical : MonoBehaviour
{
    [SerializeField] private InputController input = null;
    [SerializeField] private float speed = 1f;
    private EdgeCollider2D edge;
    
    private Vector2 edgeOffset;
    private Vector2 direction;
    private float result;
    private float topFloor = -0.19f;
    private float bottomFloor = -0.4f;

    // Start is called before the first frame update
    void Awake()
    {
        edge = GetComponent<EdgeCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.y = -input.RetrieveVerticalInput();
        if (edge.offset.y > topFloor)
        {
            edge.offset = new Vector2(edge.offset.x, topFloor);
        }
        else if (edge.offset.y < bottomFloor)
        {
            edge.offset = new Vector2(edge.offset.x, bottomFloor);
        }
        else
        {
            edge.offset = new Vector2(edge.offset.x, edge.offset.y+direction.y * Time.deltaTime * speed);
        }
        

        //result = SuperLerp(-1f, 1f, bottomFloor, topFloor, direction);
        //edge.offset = new Vector2(0,result);
    }

    private void FixedUpdate()
    {
       
    }

    


    private float SuperLerp(float from , float to ,float from2 , float to2 , float value)
    {
        if (value <= from2)
            return from;
        else if (value >= to2)
            return to;
        return (to - from) * ((value - from2) / (to2 - from2)) + from;
    }
}
