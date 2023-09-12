using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape //INHERITANCE
{
    private float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Init("Square", 3); //ABSTRACTION
    }

    // Update is called once per frame
    void Update()
    {
        if (isClicked)
        {
            PerformAction();
        }

    }

    public override void Init(string shape, int points)
    {
        base.Init(shape, points); //INHERITANCE
        rotationSpeed = 50f;
    }

    public override void PerformAction() //POLYMORPHISM
    {
        base.PerformAction();
        gameObject.transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
