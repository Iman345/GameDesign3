using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detach : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DetachChildren();
        Destroy(this.gameObject);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
