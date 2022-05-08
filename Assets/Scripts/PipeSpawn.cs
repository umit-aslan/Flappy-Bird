using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;

    void Start()
    {
        
        StartCoroutine(Spawn());
    }

 
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        while (true)
        {
        Vector3 poz=new Vector2(transform.position.x,Random.Range(-5f,-1f));
        Instantiate(pipe,poz,Quaternion.identity);
        yield return new WaitForSeconds(2);

        Destroy(pipe,13f);
        }
    }
}
