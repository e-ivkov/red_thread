using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handlers : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    delegate void Handler();
    Handler GetHandler(GameObject obj1, GameObject obj2){
        return delegate ()
        {
            Debug.Log("test");
        };
    }
}
