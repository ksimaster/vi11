using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ImGif;
using TMPro;


public class GameManager : MonoBehaviour
{
    public GameObject [] places;
    //private FixedGif fixGif;
    public GifData [] data;
    public TMP_Text title;
    private string[] joke = {"Только захотел уединиться...",
                             "Когда пытаешься победить её тараканов"};
    private int count = 0;
    private SpriteArray _sprites;

    void Start()
    {
        for (int i = 0; i < places.Length; i++)
        {
            places[i].GetComponent<FixedGif>().data = data[i];
            _sprites = GifUtility.Load(data[i]);
            places[i].GetComponent<FixedGif>()._sprites = _sprites;
        }
        count = PlayerPrefs.GetInt("Count");
        foreach (GameObject place in places)
        {
            place.SetActive(false);
        }
        places[count].SetActive(true);
        title.text = joke[count];
        
        /*
        fixGif = place.GetComponent<FixedGif>();
        fixGif.data = data[count];
        _sprites = GifUtility.Load(data[count]);
        fixGif._sprites = _sprites;
        */
    }

    public void NextGif()
    {
        places[count].SetActive(false);
        count += 1;
        if (count >= data.Length) count = 0;
        PlayerPrefs.SetInt("Count", count);
        places[count].SetActive(true);
        title.text = joke[count];
        // place.GetComponent<FixedGif>().
        /*
        Destroy(place.GetComponent<FixedGif>());
        place.AddComponent<FixedGif>();
        place.GetComponent<FixedGif>().enabled = true;
        place.GetComponent<FixedGif>().data = data[count];
        _sprites = GifUtility.Load(data[count]);
        place.GetComponent<FixedGif>()._sprites = _sprites;
        */
    }
}
