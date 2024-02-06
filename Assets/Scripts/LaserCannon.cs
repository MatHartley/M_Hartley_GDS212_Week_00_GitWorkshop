using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCannon : MonoBehaviour
{

    private bool isShooting = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isShooting = true;
            Debug.Log("Ratatat");
        }

        if (Input.GetMouseButtonUp(0))
        {
            isShooting = false;
        }

    }

}
