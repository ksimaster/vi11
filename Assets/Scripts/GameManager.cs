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
    private string[] joke = {
                            "Только захотел уединиться...",
                             "Когда предлагают выпить...",
                             "А ты шалишь?",
                             "Это я бегу на обед",
                             "Когда предлагает, но ты тупой...",
                             "Подготовка к первой дискотеке",
                             "Когда удаляешь файл, на который потрачен весь день",
                             "Я в 3 часа ночи у холодильника",
                             "Когда через 1 секунду после заказа еду еще не принесли",
                             "Я не вижу преград! Также стеклянная дверь в магазине",
                             "Весь день думаешь, что надо сделать по дому! Также уже дома",
                             "Любовь -  это ролевые игры!",
                             "Утренняя бодрость!",
                             "Она в эти дни",
                             "Когда всё бесит!",
                             "Я летучая мышь!",
                             "Когда впервые видишь ее в примерочной",
                             "Она говорит, что не голодна! Так же она в ресторане!",
                             "Когда пьяный друг, решил наехать на тебя!",
                             "Когда решил встать с кровати в выходной, но отопления нет!",
                             "Когда хвалишь за всякую мелочь",
                             "Когда решили вместе сесть на диету",
                             "Когда начальник решил дать премию в 100 рублей",
                             "Когда она говорит, что ей совсем нечего надеть!",
                             "Когда тебе намекают, но ты больше хочешь спать!",
                             "Как ты выглядишь, когда тебе кто-то нравится",
                             "Когда двое готовы подраться, а ты подливаешь масла в огонь!",
                             "Когда подруги тебе радуются",
                             "Когда она просит не подглядывать",
                             "Ты видишь, что кто-то не прав в комментариях",
                             "Длинный, скромный и болтается",
                             "Когда она решила потащить тебя по магазинам в субботу",
                             "Когда кто-то открыл шоколадку",
                             "Как вы решаете куда-то пойти",
                             "Моя гимнастка, чемпионка!"


    };
    private int count = 0;
    private SpriteArray _sprites;

    void Start()
    {
        Debug.Log("Количество шуток " + joke.Length);
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
        Debug.Log(count);
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
