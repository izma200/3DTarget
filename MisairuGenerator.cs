using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisairuGenerator : MonoBehaviour
{
    public GameObject ballPrefab;
   
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(1))
        {
            GameObject ball =
            Instantiate(ballPrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;

            ball.GetComponent<MisairuController>().Shoot(
               worldDir.normalized*20000);
           
            
            
        
        }
    }

}
