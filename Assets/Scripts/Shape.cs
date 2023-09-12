using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    private bool isTextChanged;
    public TextMeshProUGUI displayMessage;
    public bool isClicked;
    private int m_pointValue;
    public int pointValue  //ENCAPSULATION
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
    public string shapeType //ENCAPSULATION
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
        Init("Default", 0);
    }


    // Update is called once per frame
    void Update()
    {

    }

    public virtual void Init(string shape, int points)
    {
        isClicked = false;
        isTextChanged = false;
        m_shapeType = shape;
        m_pointValue = points;
    }

    private void OnMouseDown()
    {
        if (isClicked)
        {
            isClicked = false;
            isTextChanged = false;
        }
        else
        {
            isClicked = true;
        }
    }
    
    public virtual void PerformAction()
    {
        if (!isTextChanged)
        {
            displayMessage.text = m_shapeType + " is worth " + m_pointValue + " points";
            isTextChanged = true;
        }
    }
    

    

    
}
