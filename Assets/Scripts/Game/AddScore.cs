using UnityEngine;

namespace Game
{
    [RequireComponent(typeof(Collider2D))]
    public class AddScore : MonoBehaviour
    {
        [SerializeField]
        private int scoreToAdded = 1;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            var player = collision.GetComponent<Player>();
            if(player) player.Score += scoreToAdded;
        }
    }
}