using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    int i = 0;//メンバー変数
              // Use this for initialization
    void Start() {
        /*
        int n = 0;//ローカル変数
        while (i < 10)
        {
       
            i = i + 1;
            //i++;
            Debug.Log(i);

        }

        System.Random r = new System.Random();
        i = r.Next(3) + 1;
        switch (i)
        {
            case 1:
                Debug.Log("January");
                break;
            case 2:
                Debug.Log("Feburary");
                break;
            case 3:
                Debug.Log("March");
                break;
            default:
                Debug.Log(i);
                break;
            
        }
        */
        sample1(1, 5);
        sample1(2, 5);
        sample1(3, 100);
        sample1(4, 5);
        Tea("加藤");
        Tea("緑");
        Tea("麦");
        Tea("紅");
        Tea("Jasminte", "Tea");


        int c = add(1, 1);
        Debug.Log(c);
        Debug.Log(add(2, 2));
        Debug.Log(add(5, 7));
        Debug.Log(Multi(2));
        Debug.Log(Multi(70));
        Debug.Log(Multi(99,300));
        Debug.Log(Square(4));
        Debug.Log(average(4,10));
        Debug.Log(bigger(20,10));
        Debug.Log(BMI(73, 1.8f));
        Debug.Log(BMIResult(73, 1.8f));

        


    }

    // Update is called once per frame
    void Update() {

    }

    // 渡した値を10倍にしてログを出す関数
    void sample1(int a, int b)
    {
        Debug.Log(a * b);

    }

    void Tea(string a, string b = "茶")
    {
        Debug.Log(a + b);
    }

    int add(int a, int b)
    {
        int c = a + b;
        if (c < 10)
        {
            return c;
        }
        return 10;

    }

    int Multi(int a ,int b =100){
        int c = a * 2;
        if (c <= b)
        {
            return c;
        }
        return b;
    }

    void customGO(GameObject obj)
    {
        if (obj == null) return;

        // 処理
        // 処理
        // 処理
        // 処理
        // 処理
        // 処理
        //Transform trans = obj.GetComponent<Transform>();
        //trans.


    }

    /*
    戻り値の型 関数名 (引数の型 引数名 , 引数の型 引数名)
    {
        // 処理
        return 戻り値;
    }

    */
    /*
     * 問題1
整数の 2 乗を計算するメソッドを作成しなさい。１つの int 型引数を取り、
結果を int 型の戻り値として返すこと。
     */

    int Square(int a)
    {
        int c = a * a;

        return c;

    }

    /* 問題2
     * ２つの整数の平均を計算するメソッドを作成しなさい。
     * ２つの int 型引数を取り、結果を int 型の戻り値として返すこと。
     */

    int average(int a,int b)
    {
        int c = (a + b) / 2;

        return c;

    }
    /* 問題3
    * ２つの整数の大きい方を選ぶメソッドを作成しなさい。
    * ２つの int 型引数を取り、大きい方の数値を戻り値として返すこと。
    */
    int bigger(int a,int b)
    {
        if (a < b)
        {
            return b;
        }
        else
        {
            return a;
        }
    }

    float BMI(float kg ,float M)
    {
        float c = kg /( M * M);

        return c;

    }
    string BMIResult(float kg,float M)
    {
        float c = BMI(kg, M);
        string res = "";
        if (c < 19.8)
        {
            res = "やせ型";
        }
        else if (c < 24.2)
        {
            res = "普通";

        }
        else if (c < 26.4)
        {
            res = "やや肥満（過体重）";

        }
        else if (c < 35.0)
        {
            res = "肥満";

        }
        else 
        {
            res = "高度肥満（要治療）";

        }

        return res;





    }
}
