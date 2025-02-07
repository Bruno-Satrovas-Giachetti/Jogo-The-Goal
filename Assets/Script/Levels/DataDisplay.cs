using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DataDisplay : MonoBehaviour
{
    public int money;
    public int netAmount;
    public int trashCount;
    public float moveSpeed;
    public float hookSpeed;

    private void Start()
    {
        money = KeepValues.Values.money;
        netAmount = KeepValues.Values.netAmount;
        trashCount = KeepValues.Values.trashCount;
        moveSpeed = KeepValues.Values.moveSpeed;
        hookSpeed = KeepValues.Values.hookSpeed;

        ApplyTax();

        UpdateBoatPrice();
        UpdateHookPrice();

        GameObject.Find("NetAmountUI").GetComponent<TextMeshProUGUI>().text = "" + netAmount;
        GameObject.Find("MoneyUI").GetComponent<TextMeshProUGUI>().text = "Dinheiro: " + money + "$";
        //GameObject.Find("NetsUI").GetComponent<TextMeshProUGUI>().text = "Redes: " + netAmount;
        //GameObject.Find("TrashUI").GetComponent<TextMeshProUGUI>().text = "Lixo coletado: " + trashCount;
    }

    void ApplyTax()
    {
        money -= 200;
        KeepValues.Values.Buy(200);
    }

     public void BoatUpgrade()
    {
        KeepValues.Values.BoatUpgrade();
    }

    public void HookUpgrade()
    {
        KeepValues.Values.HookUpgrade();
    }

    public void BuyNet()
    {
        KeepValues.Values.BuyNet();
    }

    void UpdateBoatPrice()
    {
        if (moveSpeed == 1.2f)
        {
            GameObject.Find("UpgradeMoveSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "100 $";
            return;
        }

        else if (moveSpeed == 1.4f)
        {
            GameObject.Find("UpgradeMoveSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "300 $";
            return;
        }

        else if (moveSpeed == 1.6f)
        {
            GameObject.Find("UpgradeMoveSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "700 $";
            return;
        }

        else if (moveSpeed == 1.8f)
        {
            GameObject.Find("UpgradeMoveSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "1500 $";
            return;
        }

        else if (moveSpeed == 2.0f)
        {
            GameObject.Find("UpgradeMoveSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "3000 $";
            return;
        }

        else if (moveSpeed == 2.5f)
        {
            GameObject.Find("UpgradeMoveSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "-";
            return;
        }
    }

    void UpdateHookPrice()
    {
        if (hookSpeed == 0.5f)
        {
            GameObject.Find("UpgradeHookSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "100 $";
            return;
        }

        else if (hookSpeed == 0.7f)
        {
            GameObject.Find("UpgradeHookSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "300 $";
            return;
        }

        else if (hookSpeed == 0.9f)
        {
            GameObject.Find("UpgradeHookSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "700 $";
            return;
        }

        else if (hookSpeed == 1.1f)
        {
            GameObject.Find("UpgradeHookSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "1500 $";
            return;
        }

        else if (hookSpeed == 1.3f)
        {
            GameObject.Find("UpgradeHookSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "3000 $";
            return;
        }

        else if (hookSpeed == 1.8f)
        {
            GameObject.Find("UpgradeHookSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "-";
            return;
        }
    }
}
