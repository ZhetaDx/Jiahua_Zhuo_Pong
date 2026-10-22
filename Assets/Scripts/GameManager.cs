using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PuntosP1;
    public int PuntosP2;
    public string Marcador;
    public TextMeshProUGUI MarcadorText; 
  
    public void UpdatePointsText()
    {
        Marcador = PuntosP1 + "|" + PuntosP2;
        MarcadorText.text = Marcador;
    }
}
                    