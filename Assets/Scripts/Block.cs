using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float speed;
    public GameObject Pipes;

   void Start()
    {
        StartCoroutine(PipeSpawner()); 
    }

    IEnumerator PipeSpawner()
    {

        while(true)
        {
            yield return new WaitForSeconds(3.2f);

            var createdObject = Instantiate(Pipes, new Vector3(7, 0, 0), Quaternion.identity);
            Destroy(createdObject, 7);
            
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
