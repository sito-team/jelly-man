using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrardaloTrigger : MonoBehaviour
{
    public GameObject cosa;
    public AudioSource Daño;
    public float timer;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Daño.Play();
            cosa.SetActive(true);
            StartCoroutine("Damague");
        }

    }
    public void joselui()
    {
        cosa.SetActive(false);
    }

    IEnumerator Damague()
    {
        yield return new WaitForSeconds(timer);
        joselui();
    }
}
