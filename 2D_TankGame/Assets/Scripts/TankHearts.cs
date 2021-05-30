using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHearts : MonoBehaviour
{
    public Sprite[] HeartSprites;
    public Image HeartUI;
    private tankMovement tank_green;


    
    void Start()
    {
        tank_green = GameObject.FindGameObjectWithTag("Player").GetComponent<tankMovement>();
    }

    
    void Update()
    {
        HeartUI.sprite = HeartSprites[tank_green.curHealth];
    }
}
