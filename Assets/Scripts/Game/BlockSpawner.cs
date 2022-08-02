using System.Collections;
using UnityEngine;

namespace Game
{
    public class BlockSpawner : MonoBehaviour
    {
        [SerializeField]
        private float speed;

        [SerializeField]
        private GameObject prefab;

        private RectTransform _cachedRectTransform;

        private void Start()
        {
            StartCoroutine(Spawner());
        }

        private void Update()
        {
            if(!_cachedRectTransform) return;

            var position = _cachedRectTransform.anchoredPosition;
            _cachedRectTransform.anchoredPosition = new Vector2(position.x - speed * Time.deltaTime, position.y);
        }

        private IEnumerator Spawner()
        {
            while(true)
            {
                yield return new WaitForSeconds(5);

                if(_cachedRectTransform) Destroy(_cachedRectTransform.gameObject);

                var rand = Random.Range(-1000f, 1000f);
                var block = Instantiate(prefab, transform.parent);

                _cachedRectTransform = block.GetComponent<RectTransform>();
                if(_cachedRectTransform) _cachedRectTransform.anchoredPosition = new Vector2(500, rand);
            }
        }
    }
}