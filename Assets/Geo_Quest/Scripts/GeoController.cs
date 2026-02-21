using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class GeoController : MonoBehaviour
{

    string jaroobed = "bankai";
            int counter = 1;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("hasdasd");
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(counter);
        counter++;
        if (Input.GetKeyDown(KeyCode.W)) ;
        transform.position += new Vector3(0, 1, 0);
    }
}
    

