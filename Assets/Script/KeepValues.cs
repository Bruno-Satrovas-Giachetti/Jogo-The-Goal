using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeepValues : MonoBehaviour
{
    public static KeepValues Values;

    public int money;
    public int score;
    public float hookSpeed;
    public float moveSpeed;
    public int netAmount;
    public int trashCount;
    public int regularFishTotal;
    public int regularFishAboveQuota;
    public int rareFishTotal;

    private void Awake()
    {
        Values = this;
        DontDestroyOnLoad(gameObject);
    }

    public void RegularFishUnderQuota()
    {
        regularFishTotal++;
    }

    public void RegularFishAboveQuota()
    {
        regularFishAboveQuota++;
    }

    public void RareFishCount()
    {
        rareFishTotal++;
    }

    public void NetAmount()
    {
        netAmount--;
        GameObject.Find("Nets_UI").GetComponent<TextMeshProUGUI>().text = "" + netAmount;
    }

    public void AddMoney()
    {
        money += 50;
        GameObject.Find("Money_UI").GetComponent<TextMeshProUGUI>().text = money + "$";
    }

    public void AddExtraMoney()
    {
        money += 200;
        GameObject.Find("Money_UI").GetComponent<TextMeshProUGUI>().text = money + "$";
    }

    public void AddScore(int amount)
    {
        score += amount;
        print("Pontuação: " + score);
    }

    public void DecreaseScore(int amount)
    {
        score -= amount;
        print("Pontuação: " + score);
    }

    public void TrashCount()
    {
        trashCount++;
    }

    public void Buy(int amount)
    {
        money -= amount;
    }

    public void BoatUpgrade()
    {
        if (moveSpeed == 1.2f && money >= 100)
        {
            moveSpeed = 1.4f;
            money -= 100;
            GameObject.Find("MoneyUI").GetComponent<TextMeshProUGUI>().text = "Dinheiro: " + money + "$";
            GameObject.Find("UpgradeMoveSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "300 $";
            return;
        }

        else if (moveSpeed == 1.4f && money >= 300)
        {
            moveSpeed = 1.6f;
            money -= 300;
            GameObject.Find("MoneyUI").GetComponent<TextMeshProUGUI>().text = "Dinheiro: " + money + "$";
            GameObject.Find("UpgradeMoveSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "700 $";
            return;
        }

        else if (moveSpeed == 1.6f && money >= 700)
        {
            moveSpeed = 1.8f;
            money -= 700;
            GameObject.Find("MoneyUI").GetComponent<TextMeshProUGUI>().text = "Dinheiro: " + money + "$";
            GameObject.Find("UpgradeMoveSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "1500 $";
            return;
        }

        else if (moveSpeed == 1.8f && money >= 1500)
        {
            moveSpeed = 2.0f;
            money -= 1500;
            GameObject.Find("MoneyUI").GetComponent<TextMeshProUGUI>().text = "Dinheiro: " + money + "$";
            GameObject.Find("UpgradeMoveSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "3000 $";
            return;
        }

        else if (moveSpeed == 2.0f && money >= 3000)
        {
            moveSpeed = 2.5f;
            money -= 3000;
            GameObject.Find("MoneyUI").GetComponent<TextMeshProUGUI>().text = "Dinheiro: " + money + "$";
            GameObject.Find("UpgradeMoveSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "-";
            return;
        }
    }

    public void HookUpgrade()
    {
        if (hookSpeed == 0.5f && money >= 100)
        {
            hookSpeed = 0.7f;
            money -= 100;
            GameObject.Find("MoneyUI").GetComponent<TextMeshProUGUI>().text = "Dinheiro: " + money + "$";
            GameObject.Find("UpgradeHookSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "300 $";
            return;
        }

        else if (hookSpeed == 0.7f && money >= 300)
        {
            hookSpeed = 0.9f;
            money -= 300;
            GameObject.Find("MoneyUI").GetComponent<TextMeshProUGUI>().text = "Dinheiro: " + money + "$";
            GameObject.Find("UpgradeHookSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "700 $";
            return;
        }

        else if (hookSpeed == 0.9f && money >= 700)
        {
            hookSpeed = 1.1f;
            money -= 700;
            GameObject.Find("MoneyUI").GetComponent<TextMeshProUGUI>().text = "Dinheiro: " + money + "$";
            GameObject.Find("UpgradeHookSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "1500 $";
            return;
        }

        else if (hookSpeed == 1.1f && money >= 1500)
        {
            hookSpeed = 1.3f;
            money -= 1500;
            GameObject.Find("MoneyUI").GetComponent<TextMeshProUGUI>().text = "Dinheiro: " + money + "$";
            GameObject.Find("UpgradeHookSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "3000 $";
            return;
        }

        else if (hookSpeed == 1.3f && money >= 3000)
        {
            hookSpeed = 1.8f;
            money -= 3000;
            GameObject.Find("MoneyUI").GetComponent<TextMeshProUGUI>().text = "Dinheiro: " + money + "$";
            GameObject.Find("UpgradeHookSpeedPriceText").GetComponent<TextMeshProUGUI>().text = "-";
            return;
        }
    }

    public void BuyNet()
    {
        if (money >= 250)
        {
            netAmount++;
            money -= 250;
            GameObject.Find("MoneyUI").GetComponent<TextMeshProUGUI>().text = "Dinheiro: " + money + "$";
            GameObject.Find("NetAmountUI").GetComponent<TextMeshProUGUI>().text = "" + netAmount;
        }
    }

    public void ResetGame()
    {
        Destroy(this.gameObject);
    }

}
