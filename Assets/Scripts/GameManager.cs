using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int PuntosP1;
    public int PuntosP2;
    public string Marcador;
    public AudioClip WinSound;
    public AudioClip pointScoreSound; //Marcos tiene sida 
    public TextMeshProUGUI MarcadorText;

    public GameObject winPanel;
    private void Start()
    {
        Time.timeScale = 1f;

    }
    public void UpdatePointsText()
    {
        string lastPoints = Marcador;
        Marcador = PuntosP1 + "|" + PuntosP2;
        MarcadorText.text = Marcador;

        if (PuntosP1 == 4 || PuntosP2 == 4)
        {
            winPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    
}
                    