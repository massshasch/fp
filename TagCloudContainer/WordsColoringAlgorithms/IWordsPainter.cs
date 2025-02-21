using System.Collections.Generic;
using System.Drawing;
using TagCloudContainer.TaskResult;

namespace TagCloudContainer.WordsColoringAlgorithms
{
    public interface IWordsPainter
    {
        public Dictionary<string, Color> GetWordColorDictionary(Dictionary<string, int> frequencyDictionary,
            Color startColor);
    }
}