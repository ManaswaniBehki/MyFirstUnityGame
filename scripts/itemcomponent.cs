using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;

    [SerializeField] TextMesh CoinsText;

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sphere"))
        {
            Destroy(other.gameObject);
            coins++;
            CoinsText.text = "You have reached the end-Score:" + coins;
           
        }
    }
}
