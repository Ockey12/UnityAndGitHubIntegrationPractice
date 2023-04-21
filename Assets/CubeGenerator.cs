using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    private int cubeCounter = 0; // 立方体の数を追跡するカウンター
    private float cubeSize = 10f; // 立方体の辺の長さ
    private float spacing = 2f; // 立方体同士の間隔

    // Updateメソッドは、毎フレーム実行される
    void Update()
    {
        // スペースキーが押されたとき、立方体を生成
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateCube();
        }
    }

    // 立方体を生成するメソッド
    private void GenerateCube()
    {
        // 立方体を生成し、GameObjectに代入
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // 立方体のスケールを指定する（辺の長さが10になるように）
        cube.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);

        // 立方体の配置位置を計算し、設定する
        float positionOffset = cubeCounter * (cubeSize + spacing);
        cube.transform.position = new Vector3(positionOffset, cubeSize / 2, 0);

        // 立方体に名前を付ける（例: "Cube_0", "Cube_1", "Cube_2", ...）
        cube.name = "Cube_" + cubeCounter;

        // 立方体のカウンターをインクリメント
        cubeCounter++;
    }
}
