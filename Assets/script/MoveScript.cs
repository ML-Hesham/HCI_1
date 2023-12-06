using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    private Rigidbody2D reg;
    int speed = 40;
    int jump = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        reg = GetComponent<Rigidbody2D>();
        int x = 0;
        int y = 0;
        if(Input.GetKey("right"))
        { x = speed; }
        else if(Input.GetKey("left")) 
        { x = -speed; }
        else if (Input.GetKey("up"))
        { y = jump; }
        else
        { y = -jump; }
        reg.AddForce(new Vector2 (x, y));
    }
}
