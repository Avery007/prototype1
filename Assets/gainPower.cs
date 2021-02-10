using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gainPower : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject energy;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == energy)
        {
            Debug.Log("detection");
            Destroy(collision.collider.gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
