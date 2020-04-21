using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisairuController : MonoBehaviour
{
   
    GameObject director;
    void Start()
    {
        this.director = GameObject.Find("GameDirector");
    }


    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
        Destroy(gameObject, 2f);
       
    }

    void OnTriggerEnter(Collider other)
    {
        string yourTag = other.gameObject.tag;

        if (yourTag == "Purple")
        {
            this.director.GetComponent<GameDirector>().TouchPurple();
            GetComponent<ParticleSystem>().Play();
          
        }
        else if ( yourTag  == "Red")
        {
            this.director.GetComponent<GameDirector>().TouchRed();
            GetComponent<ParticleSystem>().Play();
           
        }
        else if (yourTag  == "Blue")
        {
            this.director.GetComponent<GameDirector>().TouchBlue();
            GetComponent<ParticleSystem>().Play();
           
        }
        else if (yourTag == "Green")
        {
            this.director.GetComponent<GameDirector>().TouchGreen();
            GetComponent<ParticleSystem>().Play();
           
        }
        Destroy(other.gameObject);
      
    }

}
