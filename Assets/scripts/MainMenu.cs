using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject btnObj = GameObject.Find("ReOpen");
        Button btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate() {
            reOpen();
        });
    }

    private void reOpen()
    {
        SceneManager.LoadScene("PlayScene");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
