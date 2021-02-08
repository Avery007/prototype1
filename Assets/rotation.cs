using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 rotatingL = new Vector3(0, 1.5f, 0);
    public Vector3 rotatingR = new Vector3(0, -1.5f, 0);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            this.GetComponent<Transform>().Rotate(rotatingL);
        }

        if (Input.GetKey(KeyCode.E))
        {
            this.GetComponent<Transform>().Rotate(rotatingR);
        }


    }
}
