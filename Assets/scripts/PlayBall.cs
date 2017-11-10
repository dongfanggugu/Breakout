using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayBall : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //将球旋转45度并向上发射
        //transform.Rotate(new Vector3(0, 1, 0) * 45);
        transform.forward = new Vector3(0, 1, 0) * 45;
        GetComponent<Rigidbody>().AddForce(transform.forward * 11f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        //始终保证球于砖块在一个平面
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);

        //小球位置检测，当低于板球位置事游戏结束
        if (transform.position.y <= -4)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //碰到砖块时，砖块消失
        if (collision.gameObject.tag == "UnitCube")
        {
            Destroy(collision.gameObject);
        }
    }
}
