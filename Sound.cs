using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace UssMang
{
    public class Sound {
        public async Task Heli(string path)
        {
            await Task.Run(() =>
            {
                using (AudioFileReader audioFileReader = new AudioFileReader(path))
                using (IWavePlayer waveOutDevice = new WaveOutEvent { DesiredLatency = 200, Volume = 50 })
                {
                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
                    while (waveOutDevice.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(1000);
                    }
                }
            });
        }
        public async Task Natuke(string path)
        {
            await Task.Run(() =>
            {
                using (AudioFileReader audioFileReader = new AudioFileReader(path))
                using (IWavePlayer waveOutDevice = new WaveOutEvent {})
                {
                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
                    while (waveOutDevice.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(50);
                    }
                }
            });
        }
    }
}
