using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mute : MonoBehaviour
{
    private bool isMute;
    // Start is called before the first frame update
    void Start()
    {
        isMute = PlayerPrefs.GetInt("Mute") == 1;
        AudioListener.pause = isMute;
    }


    public void MuteButton()
    {
        isMute = !isMute;
        AudioListener.pause = isMute;
        PlayerPrefs.SetInt("Mute", isMute ? 1 : 0);
    }
    public Sprite newSprite;
    public Sprite oldSprite;
    public void OnClick () {
        if (isMute==false){
            GetComponent<Image>().sprite = newSprite;
        }
        else {
            GetComponent<Image>().sprite = oldSprite;
        }
    }
}
