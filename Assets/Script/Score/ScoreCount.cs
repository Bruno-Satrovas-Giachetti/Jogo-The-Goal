using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    public int score;

    public int regularFishTotal;
    public int regularFishAboveQuota;
    public int rareFishTotal;
    public int trashCount;

    public int regularFishTotalScore;
    public int regularFishAboveQuotaScore;
    public int rareFishTotalScore;
    public int trashCountScore;

    private void Start()
    {
        regularFishTotal = KeepValues.Values.regularFishTotal;
        regularFishAboveQuota = KeepValues.Values.regularFishAboveQuota;
        rareFishTotal = KeepValues.Values.rareFishTotal;
        trashCount = KeepValues.Values.trashCount;

        if (regularFishAboveQuota <= 0)
        {
            regularFishTotalScore = regularFishTotal * 100;
        }

        else
        {
            regularFishTotalScore = 0;
        }

        regularFishAboveQuotaScore = regularFishAboveQuota * -200;
        rareFishTotalScore = rareFishTotal * -400;
        trashCountScore = trashCount * 200;

        score = regularFishTotalScore + regularFishAboveQuotaScore + rareFishTotalScore + trashCountScore;

        GameObject.Find("RegularFishUI").GetComponent<TextMeshProUGUI>().text = "Peixes Capturados dentro da meta: " + regularFishTotal;
        GameObject.Find("RegularFishScoreUI").GetComponent<TextMeshProUGUI>().text = "+" + regularFishTotalScore;

        GameObject.Find("RegularFishAboveQuotaUI").GetComponent<TextMeshProUGUI>().text = "Peixes Capturados acima da meta: " + regularFishAboveQuota;
        GameObject.Find("RegularFishAboveQuotaScoreUI").GetComponent<TextMeshProUGUI>().text = "" + regularFishAboveQuotaScore;

        GameObject.Find("RareFishUI").GetComponent<TextMeshProUGUI>().text = "Peixes em Extinção capturados: " + rareFishTotalScore;
        GameObject.Find("RareFishScoreUI").GetComponent<TextMeshProUGUI>().text = "" + rareFishTotalScore;

        GameObject.Find("TrashCountUI").GetComponent<TextMeshProUGUI>().text = "Lixo coletado: " + trashCount;
        GameObject.Find("TrashCountScoreUI").GetComponent<TextMeshProUGUI>().text = "+" + trashCountScore;

        if (score > 0)
        {
            GameObject.Find("TotalScoreUI").GetComponent<TextMeshProUGUI>().color = Color.green;
            GameObject.Find("TotalScoreUI").GetComponent<TextMeshProUGUI>().text = "" + score;
        }

        else
        {
            GameObject.Find("TotalScoreUI").GetComponent<TextMeshProUGUI>().color = Color.red;
            GameObject.Find("TotalScoreUI").GetComponent<TextMeshProUGUI>().text = "" + score;
        }
    }
}
