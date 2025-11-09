using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MeyveToplayacısı : MonoBehaviour
{
    [SerializeField] private Skor skor;

    private void Start()
    {
        skor = FindObjectOfType<Skor>();
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (this.tag)
        {
            case "Apple":
                skor.AddScore(1);
                Destroy(this.gameObject);
                break;

            case "Pepper":
                skor.AddScore(2);
                Destroy(this.gameObject);
                break;
            
            case "Watermelon":
                skor.AddScore(3);
                Destroy(this.gameObject);
                break;

            case "Snowball":
                skor.SubtractScore(4);
                Destroy(this.gameObject);
                break;
        }

    }
    
}