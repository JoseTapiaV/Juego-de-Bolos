using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeticion : MonoBehaviour {

    public static int repeticiones = 2;

    // Use this for initialization
    void Start () {
		
	}

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
