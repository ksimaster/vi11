using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ImGif;

public class GameManager : MonoBehaviour
{
    public GameObject place;
    private FixedGif fixGif;
    public GifData [] data;
    private int count = 0;
    private SpriteArray _sprites;

    void Start()
    {
        fixGif = place.GetComponent<FixedGif>();
        fixGif.data = data[count];
        _sprites = GifUtility.Load(data[count]);
        fixGif._sprites = _sprites;
    }

    public void NextGif()
    {
        count += 1;
        if (count > data.Length - 1) count = 0;
        // place.GetComponent<FixedGif>().
        Destroy(place.GetComponent<FixedGif>());
        place.AddComponent<FixedGif>();
        place.GetComponent<FixedGif>().enabled = true;
        place.GetComponent<FixedGif>().data = data[count];
        _sprites = GifUtility.Load(data[count]);
        place.GetComponent<FixedGif>()._sprites = _sprites;
        
    }
}
