using System;
using TagCloudContainer.TaskResult;

namespace TagCloudContainer
{
    /// <summary>
    /// Считает коэффицент для размера шрифта в зависимости от размера холста.
    /// Гарантирует что картинка не поедет при нестандартных размерах.
    /// </summary>
    public static class ScaleCoefficientCalculator
    {
        public static int CalculateScaleCoefficient(int canvasWidth, int canvasHeight, int canvasBorder)
        {
            return Math.Min(canvasWidth - canvasBorder, canvasHeight - canvasBorder) / 100 * 2;
        }
    }
}