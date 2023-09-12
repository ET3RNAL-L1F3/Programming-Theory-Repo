using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape //INHERITANCE
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
        shapeType = "Capsule";
        pointValue = 2;
        base.Init();  //INHERITANCE
    }
}
