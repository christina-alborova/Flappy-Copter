using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float speed;
    public GameObject Pipe;

   void Start()
    {
        StartCoroutine(PipeSpawner()); 
    }

    IEnumerator PipeSpawner()
    {

        while(true)
        {
            yield return new WaitForSeconds(5);
            float rand = Random.Range(-1f, 2f);
            var createdObject = Instantiate(Pipe, new Vector3(5, rand, 0), Quaternion.identity);
            Destroy(createdObject, 5);
            
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
