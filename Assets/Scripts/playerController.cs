using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject restartButton;
    public Rigidbody2D rb;
    int gemsGrabbed = 0;
    public Text winText;
    public GameObject player;
    int timeLeft = 2;
    public Text score;
    public GameObject handler;
    public AudioSource winSound;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //uses unity's built in/preset movement controls to move the character
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (gemsGrabbed == 5)
        {
            winText.gameObject.SetActive(true);
            winSound.Play();
            player.SetActive(false);
            handler.SetActive(false);
            StartCoroutine("LoseTime");
        }

        if (timeLeft == 0)
        {
            Application.Quit();
        }

        score.text = (gemsGrabbed + "/5");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "gem")
        {
            gemsGrabbed++;
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
