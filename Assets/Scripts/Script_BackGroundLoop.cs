﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_BackGroundLoop : MonoBehaviour
{
    public float bgSpeed;
    public Renderer bgRend;

    void Start()
    {

    }


    void Update()
    {
        bgRend.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0f);
    }
}
