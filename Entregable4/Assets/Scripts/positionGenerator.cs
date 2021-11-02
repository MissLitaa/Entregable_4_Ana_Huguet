using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionGenerator : MonoBehaviour
{
    public Vector3 RandomPosition()
    {
        int randX = Random.Range(0, 8);
        int randY = Random.Range(0, 8);
        int randZ = Random.Range(0, 8);
        {
            return Vector3.(randX, randY, randZ);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.Translate(RandomPosition);
        }
    }

}
