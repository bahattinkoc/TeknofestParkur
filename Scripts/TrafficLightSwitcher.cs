using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrafficLightSwitcher : MonoBehaviour
{
    public Material redLight, yellowLight, greenLight;
    public GameObject obj1, obj2;
    int counter = 0;

    void Start()
    {
        obj1.GetComponent<MeshRenderer>().material = redLight;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            switch (counter)
            {
                case 0:
                    MaterialChanger(yellowLight); break;

                case 1:
                    MaterialChanger(greenLight); break;

                case 2:
                    MaterialChanger(redLight); break;
            }
            counter = ((counter + 1) > 2) ? 0 : counter + 1;
        }
    }

    void MaterialChanger(Material mat)
    {
        obj1.GetComponent<MeshRenderer>().material = obj2.GetComponent<MeshRenderer>().material = mat;
    }
}
