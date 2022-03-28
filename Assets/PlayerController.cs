using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public AudioSource musicAudio;
 
    // Start is called before the first frame update
    void Start()
    {
       

    }
    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0.1f, 0f);
        GetComponent<Rigidbody2D>().AddForce(Vector2.up*80);
        

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if ((col.tag == ("Enemy")))
        {
            SceneManager.LoadScene("SampleScene");

        }
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount>0)
        {
            Jump();
            musicAudio.Play(0);
            
        }
       

    }
}
