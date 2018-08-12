﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class WaveEffect : TextEffect
{
    public float Frequency = 8.0f;
    public float Magnitude = 1.5f;
    public float Offset;

    private Vector3 m_startPos;

    private void Start()
    {
        m_startPos = transform.localPosition;
    }

    private void Update()
    {
        float y = Mathf.Sin( ( Offset + Time.time ) * Frequency ) * Magnitude;
        transform.localPosition = m_startPos + new Vector3( 0.0f, y, 0.0f );
    }
}
