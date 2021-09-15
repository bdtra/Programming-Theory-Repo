using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float viewDistance = 10.0f;


    // Update is called once per frame
    void Update()
    {
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(gameObject.GetComponent<Camera>().transform.position, gameObject.GetComponent<Camera>().transform.forward, out hit, viewDistance))
        {
            if (hit.transform.CompareTag("Abstraction"))
            {
                StartCoroutine(hit.transform.gameObject.GetComponent<Abstraction>().DisplayText());
            }
            else if (hit.transform.CompareTag("Encapsulation"))
            {
                StartCoroutine(hit.transform.gameObject.GetComponent<Encapsulation>().DisplayText());
            }
            else if (hit.transform.CompareTag("Polymorphism"))
            {
                StartCoroutine(hit.transform.gameObject.GetComponent<Polymorphism>().DisplayText());
            }
            else if (hit.transform.CompareTag("Inheritance"))
            {
                StartCoroutine(hit.transform.gameObject.GetComponent<Inheritance>().DisplayText());
            }
        }
    }
}
