using System;
using UnityEngine;

public class PotionDescription : MonoBehaviour
{
    public GameObject insidePotion;
    public Vector3 spawnpoint;

    private void Start()
    {
        spawnpoint = transform.position;
    }

    public Color TakeColor()
    {
        return insidePotion.GetComponent<MeshRenderer>().material.color;
    }

    public void returnOfSpawn()
    {
        transform.position = spawnpoint;
    }
}
