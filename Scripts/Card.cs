using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Card : MonoBehaviour
{
    public string suit; // Suit of the Card (C,D,H, or S)
    public int rank; // Rank of the Card (1-14)
    public Color color = Color.black; // Color to tint pips
    public string colS = "Black"; // or "Red". Name of the Color
                                  // This List holds all of the Decorator GameObjects
    public List<GameObject> decoGOs = new List<GameObject>();
    // This List holds all of the Pip GameObjects
    public List<GameObject> pipGOs = new List<GameObject>();
    public GameObject back; // The GameObject of the back of the card
    public CardDefinition def; // Parsed from DeckXML.xml
}
[System.Serializable]
public class Decorator
{
    public string type;
    public Vector3 loc;
    public bool flip = false;
    public float scale = 1f;
}
[System.Serializable]
public class CardDefinition
{
    public string face;
    public int rank; 
    public List<Decorator> pips = new List<Decorator>();

}

