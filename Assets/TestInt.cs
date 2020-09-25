using System;
using System.Collections;
using System.Collections.Generic;
using Test;
using UnityEngine;

public class TestInt : MonoBehaviour
{
    [SerializeField] private int a;
    // Start is called before the first frame update
    void Start()
    {
        List<TestEnum> testList = new List<TestEnum>();
        foreach (TestEnum item in Enum.GetValues(typeof(TestEnum)))
        {
            testList.Add(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
