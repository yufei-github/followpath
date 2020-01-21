using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{

    //Vector3 temposition;
    // Start is called before the first frame update
    void Start()
    {
      //  print("I am a cube!");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(1f * Time.deltaTime, 0f, 0f);
        //transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);
        //transform.position = Vector3.MoveTowards(transform.position, position1.transform.position, 0);

        //temposition = transform.position;
        //temposition.x += 1f;
        //transform.position = temposition;

        //transform.position += new Vector3(0.1f, 0f, 0f);

        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(0f, 0f, 1f), 1.0f * Time.deltaTime);

        transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("Building_01_01").transform.position, 1.0f * Time.deltaTime);
      



        // Move the object forward along its z axis 1 unit/second.
       // transform.Translate(0, 0, Time.deltaTime);

        // Move the object upward in world space 1 unit/second.
      //  transform.Translate(0, Time.deltaTime, 0, Space.World);
    }
}
