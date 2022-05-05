using System;
using System.Collections.Generic;
using System.Text;

namespace LabSpeech
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
