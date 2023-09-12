using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape //INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        Init();  //ABSTRACTION
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Init()  //POLYMORPHISM
    {
        shapeType = "Circle";
        pointValue = 3;
        base.Init();  //INHERITANCE
    }
}
