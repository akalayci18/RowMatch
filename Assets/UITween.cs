using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITween : MonoBehaviour
{

    [SerializeField] GameObject panel, star, glitter1, glitter2, scoreText, title; 
    void Start()
    {
        LeanTween.rotateAround(star, Vector3.forward, 360, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
