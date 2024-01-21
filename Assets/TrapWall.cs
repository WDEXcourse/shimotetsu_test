using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapWall : MonoBehaviour
{
    float pos_x = 0;
    float pos_y = 0;
    float pos_z = 0;
    float direction = 1;
    // Start is called before the first frame update
    void Start()
    {

        pos_x = transform.position.x;
        pos_y = transform.position.y;
        pos_z = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        pos_y += direction;
        if (pos_y < -10 || pos_y > 40) direction *= -1;
        transform.position = new Vector3(pos_x, pos_y, pos_z);
    }
}
