﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameInformationImage;
    public void OnInformation(){
        Time.timeScale = 0;
        gameInformationImage.SetActive(true);
    }
    public void CloseInformation(){
        Time.timeScale = 1f;
        gameInformationImage.SetActive(false);
    }

    void Update()
    {
        
    }
}
