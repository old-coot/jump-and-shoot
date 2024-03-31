using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Automat : Gun
{
    [Header("Automat")]
    public int NumberOfBullets;
    public Text BulletsText;
    public PlayerArmory PlayerArmory;

    public override void Shot()
    {
        base.Shot();
        NumberOfBullets -= 1;
        UpdateText();
        if (NumberOfBullets == 0) {
            PlayerArmory.TakeGunByIndex(0);
        }
        
    }
    
    private void UpdateText(){
        BulletsText.text = "Bullets: " + NumberOfBullets.ToString();
    }
}
