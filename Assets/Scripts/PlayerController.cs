using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D), typeof(AudioSource))]
public class PlayerController : MonoBehaviour
{
    private AudioSource _musicAudio;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _musicAudio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0) Jump();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy")) SceneManager.LoadScene("SampleScene");
    }

    private void Jump()
    {
        _musicAudio.Play(0);
        _rigidbody2D.velocity = new Vector2(0f, 0f);
        _rigidbody2D.AddForce(Vector2.up * 80);
    }
}