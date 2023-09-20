using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
   public GameObject Door;
   private static int cointCount;

    private void Start()
    {
        cointCount = 0 ;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        cointCount ++;

        Destroy(gameObject);
        Debug.Log("Tienes una moneda"+ cointCount);
    

        if (cointCount == 3)
        {
            Door.SetActive(true);
            Debug.Log("Se abre la puerta");

        }
    }

    
}
