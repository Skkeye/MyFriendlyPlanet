﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitBody : MonoBehaviour
{
    public GameObject obj;
    public GameObject player;


    void Awake()
    {
        Vector2 toPlayer = player.transform.position - obj.transform.position;
        float randomScale = Random.Range(0.2f, 0.5f);
        obj.transform.localScale = new Vector3(randomScale, randomScale, 1);
        obj.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-5f,5f), Random.Range(-5f,5f)) + toPlayer.normalized * Random.Range(5f,30f);
    }

    private void Update()
    {
        if (Mathf.Abs((player.transform.position - obj.transform.position).magnitude) > 200)
        {
            FindObjectOfType<GameManager>().objDestroid = true;
            Destroy(obj);
        }
    }
}
