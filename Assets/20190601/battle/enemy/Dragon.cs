using UnityEngine;
using UnityEditor;

public class Dragon : Enemy
{
    // コンストラクタ
    public Dragon(EnemyModel paramater) :base(paramater)// 親のコンストラクタを呼ぶことができる :base()
    {
    }
    
    public void Fly()
    {
        // 飛ぶ処理
    }
    

}