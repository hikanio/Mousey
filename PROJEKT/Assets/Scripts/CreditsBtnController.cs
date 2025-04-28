using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsBtnController : MonoBehaviour
{
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private GameObject creditsPanel;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(SettingsPanelActivate);
    }

    private void SettingsPanelActivate()
    {
        mainPanel.SetActive(false);
        creditsPanel.SetActive(true);
    }
}
