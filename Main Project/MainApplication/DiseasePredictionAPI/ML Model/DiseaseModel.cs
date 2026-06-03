using Microsoft.ML;

namespace DiseasePredictionAPI.ML_Model
{
    public class DiseaseModel
    {
        private readonly MLContext mlContext;

        public DiseaseModel()
        {
            mlContext = new MLContext();
        }

        public void Train()
        {
            IDataView data =
                mlContext.Data.LoadFromTextFile<PatientData>(
                    "patientdata.csv",
                    separatorChar: ',',
                    hasHeader: true);

            var pipeline =
                mlContext.Transforms.Concatenate(
                        "Features",
                        nameof(PatientData.Age),
                        nameof(PatientData.BloodPressure),
                        nameof(PatientData.Sugar),
                        nameof(PatientData.Cholesterol))
                .Append(
                    mlContext.BinaryClassification.Trainers
                    .SdcaLogisticRegression(
                        labelColumnName: "Disease",
                        featureColumnName: "Features"));

            var model = pipeline.Fit(data);

            mlContext.Model.Save(
                model,
                data.Schema,
                "DiseasePredictionModel.zip");
        }
    }
}
