using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour {

	// Use this for initialization
	void Start () {
        /*
        object json = {
            enemy1:
            {
            name: "バハムj-ト",
                type = "ドラゴン"
            },
            enemy2:
        {
            name: "チョコボ",
                type = "ドラゴン"
            }
    
    */

        // この辺のデータ周りは普通はサーバーから取得する
        List<EnemyModel> modelList = new List<EnemyModel>();
        EnemyModel model = new EnemyModel();
        model.name = "バハムj-ト";
        model.type = "ドラゴン";
        model.image_path = "img/bahamut.png";
        modelList.Add(model);
        EnemyModel model2 = new EnemyModel();
        model2.name = "シンリュウ";
        model2.type = "ドラゴン";
        model2.image_path = "img/sinryu.png";
        modelList.Add(model2);


        // サーバーから受け取ったデータを元に敵を生成
        for (var i = 0; i < modelList.Count; i++)
        {
            Enemy enemy = CreateEnemy(modelList[i]);
            Debug.Log(enemy.paramater_.name);
            //enemy.show();　作ったら表示するよー
        }
        
    }

    private Enemy CreateEnemy(EnemyModel model)
    {
        Enemy enemy = null;

        if (model.type == "ドラゴン")
        {
            enemy = new Dragon(model);

        } else if (model.type == "ヒューム")
        {
            //enemy = new Hum()
        }

        return enemy;

    }


	
	// Update is called once per frame
	void Update () {
		
	}
}
