﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class swiperScaling : MonoBehaviour
{

    // Start is called before the first frame update
    void Awake()
    {
        transform.LeanMoveLocal(new Vector2(560,-280), .5f).setEaseOutQuart().setLoopPingPong();
    }
}
