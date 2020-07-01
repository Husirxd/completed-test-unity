using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class menumanager : MonoBehaviour
{
   public GameObject Popup,Itext;

   public AudioSource Myaudio;
   float time;


//popupmanaganent
public void openPopup(){
Popup.SetActive(true);

}

public void closePopup(){
  Popup.SetActive(false); 
}

    

//limitedtime managament
public void openInterval(){

time=3f;
//Istnieje możliwość użycia Coroutine do osiągniecią efektu. Zdecydowałem się na Update ze względu na chęć wyświetlenia pozostałego czasu
//Itext.SetActive(true);
//StartCoroutine(Timer());
} 
/*
 IEnumerator Timer(){
yield return new WaitForSeconds(3f);
Itext.SetActive(false);
}
*/

void Update(){
if(time>0){
time -=Time.deltaTime;
Itext.SetActive(true);
Itext.GetComponent<TextMeshProUGUI>().text = "I will disappear in "+Mathf.Ceil(time);
}else{
    Itext.SetActive(false);
}

}


//audio managament
public void playAudio(){
Myaudio.Play();

}

}
