using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform POF;
    private float ZRotate;
    public int rotate;
    public AudioSource shoot;


    private void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        ZRotate = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, ZRotate + rotate);

        if (Input.GetMouseButtonDown(0))
        {
            shoot.Play();
            Instantiate(bullet, POF.position, transform.rotation);
        }
    }

}
