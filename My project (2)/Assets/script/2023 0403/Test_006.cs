using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_006 : MonoBehaviour
{
    public int[] array = new int[5];                           //array <-- 이름으로 5개의 배열(변수 int)을 선언
    public int[] points = { 83, 99, 52, 93, 15 };
    // Start is called before the first frame update
    void Start()
    {
        array[0] = 2;                                   //각가 index(array[n]) 값에 숫자 값 입력
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);                        // i (0 -> 4) 까지 증가하면서 Console.log 창에 각각의  값을 보여준다
                                                        // array[0] , array[1], array[2] , array[3] , array[4] <--- for으로 해결
        }

        int sum = 0;

        for(int i =0; i < points.Length; i++)
        {
            if(points[i] > 90)
            {
                Debug.Log(points[i]);
            }
            sum += points[i];
        }
        int average = sum / points.Length;
        Debug.Log(average);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
