using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldUiScript : MonoBehaviour
{
    public int playerGold;
    bool isNotCalled = true;
    public Text goldTextUi;

    private void Update()
    {
        goldTextUi.text = playerGold.ToString() + " Gold";

        if (isNotCalled)
        {
            InvokeRepeating("Income", 0f, 2f);
        }


    }

    public void Income()
    {
        isNotCalled = false;
        this.playerGold += 10;
    }
}
