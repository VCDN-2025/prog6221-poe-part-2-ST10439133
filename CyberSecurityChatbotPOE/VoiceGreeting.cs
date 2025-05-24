using NAudio.Wave;
using System.Threading;

namespace CyberSecurityChatbotPOE
{
    public class VoiceGreeting
    {
        public static void PlayGreeting()
        {
            //voice greeting recorded with AI inserted
            using (var audioFile = new AudioFileReader("Assets/greeting.wav"))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(100);
                }
            }
        }
    }
}
