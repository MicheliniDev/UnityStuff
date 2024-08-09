using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public EnemyScript enemy; //aaaa
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate((Vector3.forward * Time.deltaTime) * 10);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate((Vector3.back * Time.deltaTime) * 10);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate((Vector3.left * Time.deltaTime) * 10);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate((Vector3.right * Time.deltaTime) * 10);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            enemy.decreaseHP();
        }
    }
}
