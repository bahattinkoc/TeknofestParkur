using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrafficLightSwitcher : MonoBehaviour
{
    public Material redLight, yellowLight, greenLight;
    public int counter = 0;
    public float currentTime;
    public bool isTimeOver;

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = redLight;
        currentTime = 10f;
        isTimeOver = false;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.T))
        {
            isTimeOver = true;
            counter = ((counter + 1) > 2) ? 0 : counter + 1;
        }


        if (isTimeOver)
        {
            switch (counter)
            {
                case 0:
                    transform.parent.name = "tl_yellow";
                    transform.parent.tag = "34";
                    currentTime = 3f;
                    MaterialChanger(yellowLight); break;

                case 1:
                    transform.parent.name = "tl_green";
                    transform.parent.tag = "10";
                    currentTime = 10f;
                    MaterialChanger(greenLight); break;

                case 2:
                    transform.parent.name = "tl_red";
                    transform.parent.tag = "35";
                    currentTime = 10f;
                    MaterialChanger(redLight); break;
            }
            isTimeOver = false;
        }
        else
        {
            currentTime -= 1f * Time.deltaTime;
            if (currentTime <= 0f)
            {
                isTimeOver = true;
                counter = ((counter + 1) > 2) ? 0 : counter + 1;
            }
        }

    }

    void MaterialChanger(Material mat)
    {
        gameObject.GetComponent<MeshRenderer>().material = mat;
    }
}
