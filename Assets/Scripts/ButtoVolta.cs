﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtoVolta : MonoBehaviour
{
    // Start is called before the first frame update
 public void OnMouseDown()
    {
        StartCoroutine(Jogar2());
    }

    IEnumerator Jogar2(){
        if(NextConfig.Instance.modo2 == false) { 
		    SceneManager.LoadScene("Config");
    	    yield return 0;
        }
        else
        {
            SceneManager.LoadScene("Config2");
            yield return 0;
        }
    }
}
