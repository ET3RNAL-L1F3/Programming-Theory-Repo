using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private int m_pointValue;
    public int pointValue
    {
        get
        {
            return m_pointValue;
        }

        set
        {
            m_pointValue = value;
        }
    }

    private string m_shapeType;
    public string shapeType
    {
        get
        {
            return m_shapeType;
        }
        set
        {
            m_shapeType = value;
        }
    }

    private void Start()
    {
        Init();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Init()
    {
        Debug.Log("This " + m_shapeType + " is worth " + m_pointValue + " points");
    }

    private void OnMouseDown()
    {
        Debug.Log(m_shapeType);
    }
}
