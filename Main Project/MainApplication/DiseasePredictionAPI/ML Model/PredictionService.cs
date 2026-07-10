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
            MLContext mlContext = new MLContext();
            DataViewSchema schema;
            
            string modelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
      "DiseasePredictionModel.zip");

            var model = mlContext.Model.Load(modelPath, out schema);

            predictionEngine =
                mlContext.Model.CreatePredictionEngine
                <PatientData, PredictionResult>(model);
        }

        public PredictionResult Predict(PatientData patient)
        {
            return predictionEngine.Predict(patient);
        }
    }
}
