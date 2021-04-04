using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanGTFollowScript : MonoBehaviour
{
    public GameObject box;
    Vector3 posZ;

    void Start()
    {
        UpdatePos();
    }

    void Update()
    {
        UpdatePos();
    }

    void UpdatePos()
    {
        posZ = transform.position;
        posZ.y -= 0.4f;
        box.transform.position = posZ;
    }
}
