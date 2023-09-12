using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape //INHERITANCE
{
    private float speed;
    private float translateSpeed;
    private float boundary;

    // Start is called before the first frame update
    void Start()
    {
        Init("Circle", 1);  //ABSTRACTION
    }

    // Update is called once per frame
    void Update()
    {
        if (isClicked)
        {
            PerformAction();
        }
    }

    public override void Init(string shape, int points)  //POLYMORPHISM
    {
        base.Init(shape, points);  //INHERITANCE
        speed = 10;
        translateSpeed = speed;
        boundary = 10;
    }

    public override void PerformAction() //POLYMORPHISM
    {
        base.PerformAction();
        gameObject.transform.Translate(Vector3.up * translateSpeed * Time.deltaTime);
        if (transform.position.y > boundary)
        {
            translateSpeed = -speed;
        }
        if (transform.position.y < -boundary)
        {
            translateSpeed = speed;
        }

    }


}
