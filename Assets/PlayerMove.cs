using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public EnemyMove enemymove;
    private bool isFloor;

    public GameObject GoalText;
    // Start is called before the first frame update
    void Start()
    {
        isFloor = false;   
    }

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, 2);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -2);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(2, 0, 0);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-2, 0, 0);

        }

        if(Input.GetKey(KeyCode.Space) && isFloor)
        {
            rb.AddForce(0, 30, 0);
        }

        if (transform.position.y < -10.0f)
        {
            Restart();
        }
    }

    void OnCollisionStay(Collision hit) {
        if (hit.gameObject.tag == "Enemy") {
            Restart();
        }

        else if (hit.gameObject.tag == "Goal")
        {
            GoalText.SetActive (true);
        }
        else if (hit.gameObject.tag == "Floor")
        {
            isFloor = true;
        }
    }
    void OnCollisionExit(Collision unhit){
        if (unhit.gameObject.tag == "Floor")
        {
            isFloor = false;
        }
    }
    public void Restart(){
        transform.position = new Vector3(0.0f, 2.0f, 0.0f);
        rb.velocity = Vector3.zero;
        enemymove.Restart();
    }
}
