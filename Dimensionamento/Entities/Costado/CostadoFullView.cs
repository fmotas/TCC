namespace Dimensionamento.Entities.Costado
{
	public class CostadoFullView
    {		
		public CostadoInputs Inputs { get; set; }
		public CostadoOutputs Outputs { get; set; }

		public CostadoFullView(CostadoInputs inputs, CostadoOutputs outputs)
		{
			Inputs = new CostadoInputs(inputs);
			Outputs = new CostadoOutputs(outputs);
		}
	}
}
