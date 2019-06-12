using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tests  {
    public int number = 10;

    public int Kansu(int k=0)
    {
        for(int i =k +1; number>i;i++)
        {
            Debug.Log(number+i);
        }
        return 0;
    }
}
