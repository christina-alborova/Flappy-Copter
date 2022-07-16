using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class myscore : MonoBehaviour
{
    public int Addscore;
    public int Hightscore;
    public Text scoreText;
    public Text hscoreText;
    // Start is called before the first frame update
    void Start()
    {
        Addscore = 0;
        Hightscore = 0;


    }

    // Update is called once per frame
    void Update()
    {
        
        scoreText.text = Addscore.ToString();
        hscoreText.text = Hightscore.ToString();


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Block")
        {
            Addscore++;
            
        }

        if (Addscore > Hightscore)
        {
            Hightscore=Addscore;
        }
    }

}
