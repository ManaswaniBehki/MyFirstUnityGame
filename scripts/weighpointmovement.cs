using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject[] weighpoints;
    int currentweighpointindex = 0;
    [SerializeField] float speed = 1f;
    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, weighpoints[currentweighpointindex].transform.position) < .1f)
        {
            currentweighpointindex++;
            if(currentweighpointindex>=weighpoints.Length)
            {
                currentweighpointindex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, weighpoints[currentweighpointindex].transform.position, speed*Time.deltaTime);

    }
}
