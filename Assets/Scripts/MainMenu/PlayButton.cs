using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : NewSouds
{
    public void Start()
    {
        PlaySound(0, random: true);
    }

    public void Play()
    {
                SceneManager.LoadScene("Gameplay");        
    }
}