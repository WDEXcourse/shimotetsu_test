using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float player_x = player.transform.position.x;
        float player_y = player.transform.position.y;
        float player_z = player.transform.position.z;

        float enemy_x = transform.position.x;
        float enemy_y = transform.position.y;
        float enemy_z = transform.position.z;

        if (enemy_x < player_x)
        {
            enemy_x += 0.1f;
        }
        else
        {
            enemy_x -= 0.1f;
        }

        if (enemy_z < player_z)
        {
            enemy_z += 0.1f;
        }
        else
        {
            enemy_z -= 0.1f;
        }

        transform.position = new Vector3(enemy_x, enemy_y, enemy_z);
    }
}
