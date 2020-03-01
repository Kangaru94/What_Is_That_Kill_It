using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playControl : MonoBehaviour
{

    public float PlayerSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I'm a cube");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            RightPress();
        }

        if (Input.GetKey(KeyCode.A))
        {
            LeftPress();
        }

        if (Input.GetKey(KeyCode.W))
        {
            UpPress();
        }

        if (Input.GetKey(KeyCode.S))
        {
            DownPress();
        }

        if (Input.GetKey("space"))
        {
            Jump();
        }
    }

    void RightPress()
    {
        transform.Translate(PlayerSpeed * Time.deltaTime, 0f, 0f);
    }

    void LeftPress()
    {
        transform.Translate(-PlayerSpeed * Time.deltaTime, 0f, 0f);
    }

    void UpPress()
    {
        transform.Translate(0f, 0f, PlayerSpeed * Time.deltaTime);
    }

    void DownPress()
    {
        transform.Translate(0f, 0f, -PlayerSpeed * Time.deltaTime);
    }

    void Jump()
    {
        transform.Translate(0f, 5f * Time.deltaTime, 0f);
    }
}
