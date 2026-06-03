using Microsoft.ML.Data;

namespace DiseasePredictionAPI.ML_Model
{
    public class PatientData
    {
        [LoadColumn(0)]
        public float Age;

        [LoadColumn(1)]
        public float BloodPressure;

        [LoadColumn(2)]
        public float Sugar;

        [LoadColumn(3)]
        public float Cholesterol;

        [LoadColumn(4)]
        public bool Disease;
    }
}
