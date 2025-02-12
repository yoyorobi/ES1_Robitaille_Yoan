using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparitionObjet : MonoBehaviour
{
     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bille")) // Vérifie si c'est la bille qui touche
        {
            gameObject.SetActive(false); // Désactive l’objet
        }
    }
}
