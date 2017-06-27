using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Services
{
    public interface IAudioService
    {
        void AdjustVolume(double volume);
        void KillEngine();
        void ToggleEngine();
        Action OnFinishedPlaying { get; set; }
    }
}