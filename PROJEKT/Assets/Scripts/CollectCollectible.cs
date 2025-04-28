using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCollectible : MonoBehaviour
{
    [SerializeField] AudioSource collectibleFX;

    void OnTriggerEnter(Collider other)
    {
        collectibleFX.Play();
        GameInfo.collectibleCount += 1;
        this.gameObject.SetActive(false);
    }
}
