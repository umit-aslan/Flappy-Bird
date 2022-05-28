using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;//pipe prefab
    void Start()
    {
        StartCoroutine(Spawn());//Start the coroutine
    }
    IEnumerator Spawn()
    {
        while (true)
        {
        Vector3 poz=new Vector2(transform.position.x,Random.Range(-5f,-1f));//Random position for the pipe
        GameObject PipeObject=Instantiate(pipe,poz,Quaternion.identity);//Instantiate the pipe
        yield return new WaitForSeconds(1.8f);//Wait for 1.8 seconds
        Destroy(PipeObject,5f);//Destroy the pipe after 5 seconds
        }
    }
}
