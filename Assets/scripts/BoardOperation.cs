using UnityEngine;
using System.Collections;

public class BoardOperation : MonoBehaviour
{
    public float moveSpeed = 200.0f;

    // Use this for initialization
    void Start()
    {
        var playBoard = GameObject.Find("playboard");
        var renderer = playBoard.GetComponent<Renderer>();
        renderer.material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -4)
            {
                transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
            }
            else
            {
                transform.position = new Vector3(-4, transform.position.y, transform.position.z);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 4)
            {
                transform.Translate(Vector3.left * Time.deltaTime * (-moveSpeed));
            }
            else
            {
                transform.position = new Vector3(4, transform.position.y, transform.position.z);
            }
        }
    }
}
