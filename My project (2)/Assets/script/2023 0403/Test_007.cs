using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    // Start is called before the first frame update
    void SayHello()
    {
        Debug.Log("Hello");
    }

    void CallName(string name)
    {
        Debug.Log("Hello" + name);
    }
        int add(int a , int b)
    {
        int c = a + b;
        return c;
    }
    void Start()
    {
        SayHello();
        SayHello();
        CallName("TOM");
        CallName("SaM");
        int answer = add(2, 5);
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
