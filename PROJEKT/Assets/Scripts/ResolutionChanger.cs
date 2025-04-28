using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionChanger : MonoBehaviour
{
    private TMP_Dropdown resolutionDropdown;
    private Resolution[] resolutions;

    void Start()
    {
        resolutionDropdown = GetComponent<TMP_Dropdown>();
        // Pobieranie dost�pnych rozdzielczo�ci
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();

        // Konwertowanie rozdzielczo�ci na list� do Dropdown
        List<string> options = new List<string>();
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            // Sprawdzenie, czy bie��ca rozdzielczo�� jest zgodna z aktualn� rozdzielczo�ci� ekranu
            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex; // Ustawienie domy�lnego wyboru
        resolutionDropdown.RefreshShownValue(); // Od�wie�enie widocznej warto�ci

        resolutionDropdown.onValueChanged.AddListener(ChangeResolution);
    }

    public void ChangeResolution(int index)
    {
        Resolution selectedResolution = resolutions[index];
        Screen.SetResolution(selectedResolution.width, selectedResolution.height, Screen.fullScreen);
    }
}