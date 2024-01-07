using Microsoft.Extensions.Compliance.Classification;
using Microsoft.Extensions.Compliance.Redaction;

public static class DataClassifications
{
    // End User Identifiable Information
    public static DataClassification EUIIDataClassification {get;} = new DataClassification("EUIIDataTaxonomy", "EUIIData");

    // End User Pseudonymous Information
    public static DataClassification EUPDataClassification {get;} = new DataClassification("EUPDataTaxonomy", "EUPData");
}

public class EUIIDataAttribute : DataClassificationAttribute
{
    public EUIIDataAttribute() : base(DataClassifications.EUIIDataClassification) { }
}

public class EUPDataAttribute : DataClassificationAttribute
{
    public EUPDataAttribute() : base(DataClassifications.EUPDataClassification) { }
}