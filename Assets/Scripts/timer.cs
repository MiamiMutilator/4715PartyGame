using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public int timeLeft = 10;
    public Text countdown;
    public GameObject player;
    public GameObject loseText;
    public AudioSource loseSound;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        countdown.text = ("" + timeLeft);

        if (timeLeft <= 0)
        {
            countdown.text = ("");
            loseText.SetActive(true);
            loseSound.Play();
            player.SetActive(false);
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}