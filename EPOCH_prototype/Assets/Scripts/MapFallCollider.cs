﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MapFallCollider : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision) {
        SceneManager.LoadScene("Death");
    }
}
    