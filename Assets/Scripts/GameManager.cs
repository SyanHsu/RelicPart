using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    private RelicLib relicLib;

    public RelicLib RelicLib { get => relicLib; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        LoadRelicLib(Path.Combine(Application.streamingAssetsPath, "RelicLib.xml"));
        //ShowRelicLib();
    }

    private void LoadRelicLib(string path)
    {
        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
        relicLib = new RelicLib(XmlUtilty.Deserialize<RelicLibInfo>(fs));
    }

    private void ShowRelicLib()
    {
        foreach (Relic relic in relicLib.relics)
        {
            Debug.Log(relic.relicInfo.Name);
            Debug.Log(relic.relicInfo.Description);
            Debug.Log(relic.relicInfo.Rarity);
            Debug.Log(relic.relicInfo.Category);
        }
    }
}