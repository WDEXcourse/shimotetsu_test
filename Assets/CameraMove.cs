using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        // ワールド座標を基準に、回転を取得
        Vector3 worldAngle = transform.eulerAngles;
        worldAngle.x = 45.0f; // ワールド座標を基準に、x軸を軸にした回転を10度に変更
        worldAngle.y = 0.0f; // ワールド座標を基準に、y軸を軸にした回転を10度に変更
        worldAngle.z = 0.0f; // ワールド座標を基準に、z軸を軸にした回転を10度に変更
        transform.eulerAngles = worldAngle;
    }

    // Update is called once per frame
    void Update()
    {
        float pos_x = player.transform.position.x;
        float pos_y = player.transform.position.y;
        float pos_z = player.transform.position.z;

        transform.position = new Vector3(pos_x, pos_y + 10, pos_z - 10);
    }
}
