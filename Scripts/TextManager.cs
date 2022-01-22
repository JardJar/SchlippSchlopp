using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public static TextManager tm;
    private bool schlippSchlopp = true;
    [SerializeField]
    private TextMeshProUGUI btnPointsText, statPointsText, amntUpgradeText, multUpgradeText;
    private void Awake()
    {
        tm = this;
    }

    public void SetText(string newText, string perClick, string schlopp, string schloppschlipps)
    {
        btnPointsText.text = schloppschlipps;
        schlippSchlopp = !schlippSchlopp;
        statPointsText.text = "Schlipps:\n"+newText+"\nSchlopps:\n" + schlopp + "\nPer click\n" + perClick;
    }
    public void UpdateUpgradeText(string upgradeText, string multiplyText)
    {
        amntUpgradeText.text = "Upgrade coins per click:\n" + upgradeText;
        multUpgradeText.text = "Multiply coins per click:\n" + multiplyText;
    }
}