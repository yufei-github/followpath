using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{
    public Transform[] target;
    public float speed;
    public int current;


    // Update is called once per frame
    void Update()
    {
     //  if (transform.position != target[current].position) {
        //   Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
        // Rigidbody rb = GetComponent<Rigidbody>();
         //  GetComponent<Rigidbody>().MovePosition(pos);
        // }
      //   else current = (current + 1) % target.Length;
        for (int i= 0;i <target.Length; i++){
            if (transform.position != target[current].position)
            {
                transform.position = Vector3.MoveTowards(transform.position, target[i].position, speed * Time.deltaTime);
                //transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("box").transform.position, 1.0f * Time.deltaTime);
            }

        }

    }
}
