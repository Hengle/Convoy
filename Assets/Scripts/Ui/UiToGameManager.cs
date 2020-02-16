﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiToGameManager : MonoBehaviour {
    
    void Awake() {
        SceneManager.LoadScene("UiOverlay", LoadSceneMode.Additive);
    }

    void Update() {
        
    }

    
    // To used by the button from SummonUnitsButton Object
    public void Summon(GameObject unit) {
        // Summon Unit from truck here

        // This is a temporary item, delete below when necessary
        Instantiate(unit, 
                new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f)), 
                Quaternion.identity);
    }
}