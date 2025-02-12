using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouton : MonoBehaviour
{
   public GameObject porte; // Assigne la porte dans l'inspecteur

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Domino")) // Vérifie si c'est un domino
        {
            porte.SetActive(false); // Désactive la porte
        }
    }
}
