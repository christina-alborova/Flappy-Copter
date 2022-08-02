using System;
using UnityEngine;

namespace Game
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private float jumpSpeed = 80f;

        [SerializeField]
        private AudioSource audioSource;

        [SerializeField]
        private Rigidbody2D rigidbody2D;

        private int _score;

        public int Score
        {
            get => _score;
            set
            {
                _score = value;
                if(_score > Record) Record = _score;
                ScoreChanged?.Invoke();
            }
        }

        public int Record { get; private set; }
        
        public event Action ScoreChanged;

        private void Update()
        {
            if(Input.GetMouseButtonDown(0) || Input.touchCount > 0) Jump();
        }

        private void Jump()
        {
            audioSource.Play();
            rigidbody2D.velocity = new Vector2(0f, 0f);
            rigidbody2D.AddForce(Vector2.up * jumpSpeed);
        }
    }
}