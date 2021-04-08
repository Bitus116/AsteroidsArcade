using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class Score_manager : MonoBehaviour
{

    public static int score;//score
    public int HS;//high score
    public Text ScorePointInGame;
    public Text ScorePoints;
    public Text[] HI;
    public bool issaved = false;
    public string filename;
 
    private void Start()
    {
        LoadXml();
        LoadScore();
    }
    void Update()
    {
        if (score > HS) HS = score;
        if (Asteroid_action.isPlayer) LoadScore();
        if (Asteroid_action.IsMeteor)
        {
            points();
            Asteroid_action.IsMeteor = false;
        }
        

    }

    private void OnApplicationQuit()
    {
        SaveXML();
    }
    void SaveXML()
    {
        try
        {
            XmlElement element;
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("GameData");
            xmlDoc.AppendChild(rootNode);
            element = xmlDoc.CreateElement("HIScore");
            element.SetAttribute("value", HS.ToString());
            rootNode.AppendChild(element);
            xmlDoc.Save(Application.persistentDataPath + "/" + filename + ".xml");
            issaved = true;
        }
        catch
        {
            issaved = false;
            SaveXML();
        }
        
    }
    void LoadXml()
    {
        XmlTextReader reader = new XmlTextReader(Application.persistentDataPath + "/" + filename + ".xml");
        while (reader.Read())
        {
            if (reader.IsStartElement("HIScore"))
            {
                int k;
                if (int.TryParse(reader.GetAttribute("value"), out k)) HS = k;
            }

        }
    }
    void LoadScore()
    {
        
        ScorePoints.text = "SCORE:" + score;
        for(int i = 0; i < HI.Length; i++)
        {
            HI[i].text = "HI:" + HS;
        }  
    }
    public  void points()
    {
        ScorePointInGame.text = "SCORE : " + score;
    }

}