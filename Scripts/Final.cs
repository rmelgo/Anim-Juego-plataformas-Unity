﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Final : MonoBehaviour
{
    public Text text;

    // Use this for initialization
    void Start()
    {
        text.text = "Muertes: " + Muertes.pMuertes;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
