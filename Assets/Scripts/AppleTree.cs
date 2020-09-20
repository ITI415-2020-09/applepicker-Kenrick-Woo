﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    [Header("Set in Inspector")]
    // Prefab for instantiating apples
    public GameObject applePrefab;

    // Speed at which the AppleTree moves
    public float speed = 1f;

    // Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;

    // Chance that the AppleTree will change di
    public float chanceToChangeDirection = 0.1f;

    // Rate at which Apples will be instantiate
    public float secondsBetweenAppleDrop = 1f;

    void Start() {
        // Dropping apples every second
    }

    void Update() {
        // Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // Changing Direction
    }
}