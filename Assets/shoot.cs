using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("check");
        if (collision.collider.gameObject == player)
        {
            Debug.Log("detection");
            Vector3 force = new Vector3(100, 0, 100);
            player.GetComponent<Transform>().position = force;
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
