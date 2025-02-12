using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coursesaumon : MonoBehaviour
{
    Vector3 vitesse;
    // Start is called before the first frame update
    void Start()
    {
        vitesse.z = Random.Range(0f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vitesse * Time.deltaTime, Space.Self);
        if(transform.position.x > 5f)
        {
            Debug.Log(gameObject.name);
        }
    }
}
