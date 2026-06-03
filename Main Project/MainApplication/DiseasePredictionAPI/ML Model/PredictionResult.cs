using Microsoft.ML.Data;

namespace DiseasePredictionAPI.ML_Model
{
    public class PredictionResult
    {
        [ColumnName("PredictedLabel")]
        public bool Prediction { get; set; }

        public float Probability { get; set; }

        public float Score { get; set; }
    }
}
