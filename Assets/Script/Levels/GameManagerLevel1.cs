using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerLevel1 : MonoBehaviour
{
    public static GameManagerLevel1 Instance;

    public int quota;
    public int fishCount;
    public int money;
    public int netAmount;
    public int trash;
    public int fishTotal;
    [SerializeField] private int rareFishCount1;
    [SerializeField] private int rareFishCount2;
    float time;

    [SerializeField] AudioSource timeUpSound;

    [SerializeField] GameObject Rare1Info, Rare2Info;

    private void Awake()
    {
        Instance = this;
    }

    public void Start()
    {
        Rare1Info.SetActive(false);
        Rare2Info.SetActive(false);

        time = 121.0f;

        money = KeepValues.Values.money;
        netAmount = KeepValues.Values.netAmount;
        //trash = KeepValues.Values.trashCount;
        //fishTotal = KeepValues.Values.regularFishTotal;

        GameObject.Find("Money_UI").GetComponent<TextMeshProUGUI>().text = money + "$";
        GameObject.Find("Nets_UI").GetComponent<TextMeshProUGUI>().text = "" + netAmount;
        GameObject.Find("Timer_UI").GetComponent<TextMeshProUGUI>().text = "2:00";
        GameObject.Find("Quota_UI").GetComponent<TextMeshProUGUI>().text = "Meta: " + quota;

    }

    private void Update()
    {
        time = time - Time.deltaTime;
        int seconds = (int)(time % 60);
        int minutes = (int)(time / 60);

        if (time >= 60)
        {
            GameObject.Find("Timer_UI").GetComponent<TextMeshProUGUI>().text = minutes + ":" + seconds;
        }

        else if (time < 4 && time > 2)
        {
            timeUpSound.Play();
            GameObject.Find("Timer_UI").GetComponent<TextMeshProUGUI>().text = "" + seconds;
        }

        else if (time >= 0)
        {
            GameObject.Find("Timer_UI").GetComponent<TextMeshProUGUI>().text = "" + seconds;
        }

        else if (time < 0)
        {
            GameObject.Find("Timer_UI").GetComponent<TextMeshProUGUI>().text = "...";
            ChooseLevel();
        }
    }

    public void FillQuota()
    {
        quota--;
        if (quota > 0)
        {
            GameObject.Find("Quota_UI").GetComponent<TextMeshProUGUI>().text = "Meta: " + quota;
        }
        if (quota <= 0)
        {
            GameObject.Find("Quota_UI").GetComponent<TextMeshProUGUI>().text = "Meta Atingida!";
            GameObject.Find("Quota_UI").GetComponent<TextMeshProUGUI>().color = Color.green;
        }

    }

    public void FishCount()
    {
        fishCount++;
    }

    public void RareFishCount1()
    {
        rareFishCount1--;
    }

    public void RareFishCount2()
    {
        rareFishCount2--;
    }

    private void ChooseLevel()
    {
        if (SceneManager.GetActiveScene().name == "Level1") 
        {
            if (fishCount >= 15 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Upgrade2_1");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Upgrade2_2");
            }
            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Upgrade2_3");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Upgrade2_4");
            }
            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Upgrade2_5");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Level2_1")
        {
            if (fishCount >= 15 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Upgrade3_1");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Upgrade3_2");
            }
            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Upgrade3_3");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Upgrade3_4");
            }
            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Upgrade3_10");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Level2_2")
        {
            if (fishCount > 0 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Upgrade3_2");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Upgrade3_3");
            }
            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Upgrade3_5");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Upgrade3_6");
            }
            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Upgrade3_2");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Level2_3")
        {
            if (fishCount > 0 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Upgrade3_3");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Upgrade3_4");
            }
            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Upgrade3_7");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Upgrade3_6");
            }
            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Upgrade3_3");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Level2_4")
        {
            if (fishCount > 0 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Upgrade3_4");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Upgrade3_6");
            }
            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Upgrade3_8");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Upgrade3_9");
            }
            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Upgrade3_4");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Level2_5")
        {
            if (fishCount >= 15 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Upgrade3_1");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Upgrade3_2");
            }
            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Upgrade3_3");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Upgrade3_4");
            }
            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Ending5");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Level3_1")
        {
            trash = KeepValues.Values.trashCount;
            fishTotal = KeepValues.Values.regularFishTotal;
            if (fishTotal == 45 && trash == 30)
            {
                SceneManager.LoadScene("MichaelUpgrade");
            }

            else if (fishCount >= 15 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Ending1");
            }

            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Ending2");
            }

            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Ending2");
            }

            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Ending3");
            }

            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Ending1");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Level3_2")
        {
            if (fishCount > 0 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Ending2");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Ending3");
            }
            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Ending3");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Ending3");
            }
            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Ending1");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Level3_3")
        {
            if (fishCount > 0 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Ending2");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Ending3");
            }
            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Ending3");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Ending3");
            }
            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Ending1");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Level3_4")
        {
            if (fishCount > 0 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Ending3");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Upgrade4");
            }
            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Ending3");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Upgrade4");
            }
            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Ending3");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Level3_5")
        {
            if (fishCount > 0 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Ending3");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Upgrade4");
            }
            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Ending3");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Upgrade4");
            }
            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Ending3");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Level3_6")
        {
            if (fishCount > 0 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Ending3");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Upgrade4");
            }
            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Upgrade4");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Upgrade4");
            }
            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Ending3");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Level3_7")
        {
            if (fishCount > 0 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Ending3");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Upgrade4");
            }
            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Ending3");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Upgrade4");
            }
            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Ending3");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Level3_8")
        {
            if (fishCount > 0 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Ending3");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Ending3");
            }
            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Upgrade4");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Upgrade4");
            }
            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Ending3");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Level3_9")
        {
            if (fishCount > 0 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Upgrade4");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Upgrade4");
            }
            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Upgrade4");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Upgrade4");
            }
            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Ending3");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Level3_10")
        {
            if (fishCount >= 15 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Ending1");
            }

            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Ending2");
            }

            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Ending2");
            }

            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Ending3");
            }

            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Ending5");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Level4")
        {
            if (fishCount > 0 && rareFishCount1 > 0 && rareFishCount2 > 0)
            {
                //RareNone = true;
                SceneManager.LoadScene("Ending4");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 > 0)
            {
                //RareOne = true;
                SceneManager.LoadScene("Ending4");
            }
            else if (rareFishCount1 > 0 && rareFishCount2 <= 0)
            {
                //RareTwo = true;
                SceneManager.LoadScene("Ending4");
            }
            else if (rareFishCount1 <= 0 && rareFishCount2 <= 0)
            {
                //RareBoth = true;
                SceneManager.LoadScene("Ending4");
            }
            else
            {
                //NoFish = true;
                SceneManager.LoadScene("Ending4");
            }
        }

        else if (SceneManager.GetActiveScene().name == "MichaelLevel")
        {
                SceneManager.LoadScene("Ending1");
        }
    }
}
