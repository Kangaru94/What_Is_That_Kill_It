using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Messing around with creating my own classes
// Serialiazable makes it available in unity window
[System.Serializable]
public class MyData
{
    public int ValueOne;
    public int ValueTwo;
}
public class LightToggle : MonoBehaviour
{
    public Light myLight;
    public MyData DataClass;

    
    // Start is called before the first frame update
    void Start()
    {
       if (myLight.enabled == false)
        {
            myLight.enabled = true;
            Debug.Log("Let there be light!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.L))
        {
            LightSwitch();
        }

        if (Input.GetKeyDown("space"))
        {
            SpaceTest();
        }
    }

    void LightSwitch()
    {
        myLight.enabled = !myLight.enabled;

       if (myLight.enabled == true)
        {
            Debug.Log("Light toggled on");
        }
       else
        {
            Debug.Log("Light toggled off");
        }

    }

    void SpaceTest()
    {
        Debug.Log("You've pressed space, congrats, I guess.");
    }
}
