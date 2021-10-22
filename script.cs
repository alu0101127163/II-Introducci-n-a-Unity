using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLogs : MonoBehaviour {
    private int counter;

    // Start is called before the first frame update
    void Start() {
    	int cnt = 0;
    	 Debug.Log("Objeto creado" + gameObject.name);

    }

    // Update is called once per frame
    void Update() {
    	Debug.Log("Identificador" + gameObject.tag);
    	Debug.Log("Contador" + cnt);
    	cnt++:

    }
}
