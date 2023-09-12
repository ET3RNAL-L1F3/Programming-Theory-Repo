using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape //INHERITANCE
{
   
    // Start is called before the first frame update
    void Start()
    {
        Init(); //ABSTRACTION
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Init()  //POLYMORPHISM
    {
        shapeType = "Square";
        pointValue = 1;
        base.Init();  //INHERITANCE
    }
}
