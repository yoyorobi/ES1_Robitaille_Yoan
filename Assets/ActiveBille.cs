using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveBille : MonoBehaviour
{
    public GameObject bille;
    public Rigidbody bille1;
    public float vitesseInitiale = 10f;
    

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other) {
        if(other.gameObject == bille) {
        bille1.isKinematic = false;        
        bille1.useGravity = true;
        bille1.velocity = transform.forward * vitesseInitiale;
    }
    }
    
        
    
}
