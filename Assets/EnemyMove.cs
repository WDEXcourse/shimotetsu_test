using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Restart();
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

        float enemy_speed = 0.01f;

        if (enemy_x < player_x)
        {
            enemy_x += enemy_speed;
        }
        else
        {
            enemy_x -= enemy_speed;
        }

        if (enemy_z < player_z)
        {
            enemy_z += enemy_speed;
        }
        else
        {
            enemy_z -= enemy_speed;
        }

        transform.position = new Vector3(enemy_x, enemy_y, enemy_z);
    }
    public void Restart(){
        transform.position = new Vector3(0.0f,0.3f,25.0f);
    }
}
