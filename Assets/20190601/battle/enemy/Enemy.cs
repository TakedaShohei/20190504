using UnityEngine;
using UnityEditor;

public class Enemy 
{
    public EnemyModel paramater_ = null;

    // コンストラクタ
    public Enemy(EnemyModel paramater)
    {
        paramater_ = paramater;
        // 処理を追加してもOK
    }

}