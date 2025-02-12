using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoutonPlatforme : MonoBehaviour
{
    public GameObject plateforme; // Assigne la plateforme dans l'Inspector

    public void DesactiverPlateforme()
    {
        if (plateforme != null)
        {
            plateforme.SetActive(false); // Désactive la plateforme
        }
    }
}
