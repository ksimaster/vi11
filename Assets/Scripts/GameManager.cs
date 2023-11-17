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
                             "Когда предлагают выпить...",
                             "Когда до конца рабочего дня еще 30 минут",
                             "Это я бегу на обед",
                             "Когда предлагает, но ты тупой...",
                             "Когда вдруг услышал свое имя в разговоре",
                             "Когда удалил файл, который делал весь день",
                             "Я на диете, так же я в 3 часа ночи у холодильника",
                             "Когда только что сделал заказ, но через 0.1 секунды еду еще не принесли",
                             "Я не вижу преград! Так же стеклянная дверь в магазине",
                             "Весь день думаешь, что надо сделать по дому! Так же я, когда пришел домой",
                             "Когда ты на 5 сантиметров выше ее",
                             "Сижу на планерке в понедельник и внимательно слушаю",
                             "Когда спрашивают, кто дежурит в выходные?",
                             "Когда говорят, что все надо переделать!",
                             "Начальник сказал, что надо поработать сверхурочно",
                             "Когда впервые видишь ее в примерочной",
                             "Она говорит, что не гододна! Так же она в ресторане!",
                             "Когда пьяный друг, который не стоит на ногах решил наехать на тебя!",
                             "Когда решил встать с кровати в выходной, но отопления нет!",
                             "Она посмотрела видео для взрослых и решила повторить!",
                             "Когда на работе просто принес документы, но тебя похвалили",
                             "Когда решили вместе сесть на диету",
                             "Когда начальник решил дать премию в 100 рублей",
                             "Когда она говорит, что ей совсем нечего надеть!",
                             "Когда она тебе намекает, но ты больше хочешь спать!",
                             "Когда спрашивают почему такой красавец не женат? Так же я",
                             "Когда на корпоративе двое почти готовы подраться, а ты подлил масла в огонь!",
                             "Когда сдал всю отчетность",
                             "Когда она просит не подглядывать",
                             "Когда еда мерзкая, но первая за день!",
                             "Когда включил фильм и решил настроиться",
                             "Когда она решила потащить тебя по магазинам в субботу",
                             "Когда открыл шоколадку на работе",
                             "Когда рассказал другу, что этой ночью ты смог",
                             "Когда после ужина она правильно намекает на десерт",
                             "Когда скачал не правильную инструкцию по приготовлению фруктового салата",
                             "Когда пришел с работы вечером и тут понял, что женился удачно"







    };
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
