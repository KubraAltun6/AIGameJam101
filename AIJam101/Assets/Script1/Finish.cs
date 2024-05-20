using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] GameObject panel;
    private void Start()
    {
        panel.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Finish"))
        {
            panel.SetActive(true);
        }
    }
}
