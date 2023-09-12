using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape //INHERITANCE
{
    private float scaleRate;
    private float scale;

    // Start is called before the first frame update
    void Start()
    {
        Init("Capsule", 2);  //ABSTRACTION
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
        scale = .05f;
        scaleRate = scale;
    }

    public override void PerformAction()
    {
        base.PerformAction();
        if (transform.localScale.y > 10)
        {
            scaleRate = -scale;
        }
        if (transform.localScale.y < 2)
        {
            scaleRate = scale;
        }
        transform.localScale = new Vector3(scaleRate, scaleRate, scaleRate) + transform.localScale;
    }
}
