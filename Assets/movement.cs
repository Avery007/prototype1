using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position= this.transform.position+ new Vector3(1.0f,0,0);

        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position = this.transform.position - new Vector3(1.0f, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position = this.transform.position + new Vector3(0, 0, 1.0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position = this.transform.position - new Vector3(0, 0, 1.0f);
        }

   




    }
}
