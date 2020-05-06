using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{

    public IEnumerator CamShake(float ShakeTime,float ShakeMag)
    {
        Vector3 Campos = transform.localPosition;
        float ShakeCounter = 0.0f;

        while (ShakeCounter < ShakeTime)
        {
            float xpos = Random.Range(-1f, 1f) * ShakeMag;
            float ypos = Random.Range(-1f, 1f) * ShakeMag;

            transform.localPosition = new Vector3(xpos, ypos, Campos.z);
            ShakeCounter += Time.deltaTime;
            yield return null;
        }

        transform.localPosition = Campos;
    }

    private void Update()
    {

        if (Input.GetButtonDown("Fire1"))
            {

          
           // StartCoroutine(CamShake(0.15f, 0.4f));

            
        }
    }
}
