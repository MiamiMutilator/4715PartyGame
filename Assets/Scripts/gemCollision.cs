using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class gemCollision : MonoBehaviour
{
    public AudioSource pickupSound;
    public ParticleSystem particles;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            particles.Play();
            pickupSound.Play();
            this.gameObject.SetActive(false);
        }
    }
}