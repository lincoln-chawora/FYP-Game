﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{

    public string name;

    [TextArea(3, 10)]
    public string[] setences;

    [TextArea(3, 10)]
    public string[] secondRoundSetences;

    [TextArea(3, 10)]
    public string[] thirdRoundSetences;


}