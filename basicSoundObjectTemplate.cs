using System;
using System.Media;

public class Sounds
{
    //Create the Sound objects
    private SoundPlayer bounce = new SoundPlayer(@"../sounds/bounce.mp3");
    private SoundPlayer chirp = new SoundPlayer(@"../sounds/chirp.mp3");
    private SoundPlayer meow = new SoundPlayer(@"../sounds/meow.mp3");

    public Sounds()
    {
    }

    //Play Bounce sound
    public void PlayBounceSound()
    {
        bounce.Play();
    }

    //Play Chirp sound
    public void PlayChirpSound()
    {
        chirp.Play();
    }

    //Play Meow sound
    public void PlayMeowSound()
    {
        meow.Play();
    }
}