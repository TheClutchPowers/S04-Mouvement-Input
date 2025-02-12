using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coursepoisson : MonoBehaviour
{
   
       public float vitesse = Random.Range(0, 10);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, vitesse * Time.deltaTime, Space.Self);
    }
}
