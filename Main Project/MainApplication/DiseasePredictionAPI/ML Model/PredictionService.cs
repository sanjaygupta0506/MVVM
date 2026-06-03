using Microsoft.ML;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiseasePredictionAPI.ML_Model
{
    public class PredictionService
    {
        private readonly PredictionEngine
        <PatientData, PredictionResult> predictionEngine;

        public PredictionService()
        {
            var mlContext = new MLContext();

            string modelPath =
    Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        "Models",
        "DiseasePredictionModel.zip");

            Directory.CreateDirectory(
                Path.GetDirectoryName(modelPath)!);

            //mlContext.Model.Save(
            //    model,
            //    data.Schema,
            //    modelPath);
        }

        public PredictionResult Predict(PatientData patient)
        {
            return predictionEngine.Predict(patient);
        }
    }
}
