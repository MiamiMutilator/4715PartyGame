using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class infoNext : MonoBehaviour
{
    private int timeLeft = 2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft <= 0)
        {
            //advances to the next scene
            SceneManager.LoadScene("PlayScene");
        }
    }
    //uses waitforseconds to count down from variable value once per second
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}